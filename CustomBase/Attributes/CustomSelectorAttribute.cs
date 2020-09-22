using System;

namespace CustomBase.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class CustomSelectorAttribute : Attribute
    {
        public CustomSelectorAttribute(string selector)
        {
            this.Selector = selector;
        }
        public string Selector { get; }
    }
}
