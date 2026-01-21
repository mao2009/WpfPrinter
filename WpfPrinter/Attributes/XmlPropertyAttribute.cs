using System;

namespace WpfPrinter.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class XmlPropertyAttribute : Attribute
    {
        public XmlPropertyAttribute()
        {
        }
    }
}
