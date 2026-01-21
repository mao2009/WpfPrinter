using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Xml.Linq;
using WpfPrinter.Attributes;
using WpfPrinter.Consts;
using WpfPrinter.Interfaces;

namespace WpfPrinter.ViewModels
{
    public abstract class BaseReportLayoutViewModel : IReportLayoutViewModel
    {

        public const string DefaultMergin = "0";
        public const int DefaultWidth = LayoutSizes.A4.Width;
        public const int DefaultHeight = LayoutSizes.A4.Width;

        [XmlProperty]
        public virtual int TitleFontSize { get; set; } = 20;

        [XmlProperty]
        public virtual int GeneralFontSize { get; set; } = 12;

        [XmlProperty]
        public virtual int ItemFontSize { get; set; } = 10; // 明細行のフォントサイズ


        [XmlProperty]
        public virtual int ItemHeight { get; set; } = 20; // 明細行の高さ

        [XmlProperty]
        [XmlPropertyThickness]
        public virtual Thickness Margin { get; set; } = new Thickness(0);

        [XmlProperty]
        public virtual double Width { get; set; } = LayoutSizes.A4.Portrait.Width; // A4 width in 100th mm

        [XmlProperty]
        public virtual double Height { get; set; } = LayoutSizes.A4.Portrait.Height; // A4 height in 100th mm

        [XmlProperty]
        public virtual int MaxItemCount { get; set; } = 20; // 最大明細行数

        public virtual string LayoutsFile { get; set; } = "Layouts.xml"; // XMLファイル名

        public abstract string XmlName { get; set; } // XMLキー名

        public ObservableCollection<IReportItemLayoutViewModel> Details { get; set; } = new ObservableCollection<IReportItemLayoutViewModel>();

        [XmlProperty]
        public virtual string Title { get; set; } = "レポートタイトル"; // レポートのタイトル

        public BaseReportLayoutViewModel() { }


        /// <summary>
        /// レイアウトのXMLファイルを読み込む
        /// </summary>
        /// <returns></returns>
        public XElement LoadLayouts()
        {
            if (File.Exists(LayoutsFile))
            {
                return XElement.Load(LayoutsFile);
            }
            else
            {
                // Return an empty XElement to avoid NullReferenceException later
                return new XElement("Layouts"); 
            }
        }

        public static string ConvertToString(Thickness value)
        {
            return $"{value.Left},{value.Top},{value.Right},{value.Bottom}";
        }

        public static Thickness ConvertToThickness(string value)
        {
            var values = value.Split(',');

            if (values.Length == 1)
            {
                // すべての辺が同じ値
                if (double.TryParse(values[0], out var thickness))
                {
                    return new Thickness(thickness);
                }
            }
            else if (values.Length == 4)
            {
                // 左、上、右、下の値
                if (double.TryParse(values[0], out var left) &&
                    double.TryParse(values[1], out var top) &&
                    double.TryParse(values[2], out var right) &&
                    double.TryParse(values[3], out var bottom))
                {
                    return new Thickness(left, top, right, bottom);
                }
            }
            else if (values.Length == 2)
            {
                // 左右、上下の値
                if (double.TryParse(values[0], out var left) &&
                    double.TryParse(values[1], out var top))
                {
                    return new Thickness(left, top, left, top);
                }
            }

            // Parsing failed or invalid format, return default or throw a more specific exception
            throw new FormatException("Invalid format for Thickness conversion.");
        }

        public static T GetXmlValue<T>(XElement xml, string name, T defaultValue)
        {
            try
            {
                var element = xml.Element(name);
                if (element == null || string.IsNullOrEmpty(element.Value))
                {
                    return defaultValue;
                }

                var targetType = typeof(T);
                if (targetType == typeof(object))
                {
                    if (defaultValue is string)
                    {
                        return (T)(object)element.Value;
                    }
                    else if (defaultValue is double)
                    {
                        if (double.TryParse(element.Value, out double value))
                        {
                            return (T)(object)value;
                        }
                    }
                    else if (defaultValue is int)
                    {
                        if (int.TryParse(element.Value, out int value))
                        {
                            return (T)(object)value;
                        }
                    }
                    else if (defaultValue is bool)
                    {
                        if (bool.TryParse(element.Value, out bool value))
                        {
                            return (T)(object)value;
                        }
                    }
                }
                else if (targetType == typeof(int))
                {
                    if (int.TryParse(element.Value, out int intValue))
                    {
                        return (T)(object)intValue;
                    }
                }
                else if (targetType == typeof(double))
                {
                    if (double.TryParse(element.Value, out double doubleValue))
                    {
                        return (T)(object)doubleValue;
                    }
                }
                else if (targetType == typeof(bool))
                {
                    if (bool.TryParse(element.Value, out bool boolValue))
                    {
                        return (T)(object)boolValue;
                    }
                }
                else if (targetType == typeof(string))
                {
                    return (T)(object)element.Value;
                }

                return defaultValue;
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }

        public void SetLayouts()
        {
            var loadedXml = LoadLayouts();
            var xmlElement = loadedXml.Element(XmlName);

            if (xmlElement != null)
            {
                var properties = this.GetType().GetProperties();
                foreach (var property in properties.Where(p => p.GetCustomAttribute<XmlPropertyAttribute>() != null))
                {
                    var defaultValue = property.GetValue(this, null);

                    if (property.GetCustomAttribute<XmlPropertyThicknessAttribute>() != null)
                    {
                        if (defaultValue is Thickness thickness)
                        {
                            var converted = GetXmlValue<string>(xmlElement, property.Name, ConvertToString(thickness));
                            property.SetValue(this, ConvertToThickness(converted), null);
                        }
                        else
                        {
                            throw new Exception("Unspported type propery.");
                        }
                    }
                    else
                    {
                        property.SetValue(this, GetXmlValue(xmlElement, property.Name, defaultValue), null);
                    }
                }
            }
        }
    }
}
