using System;

namespace WpfPrinter.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class XmlPropertyThicknessAttribute : Attribute
    {
        public XmlPropertyThicknessAttribute()
        {
        }
    }
}
