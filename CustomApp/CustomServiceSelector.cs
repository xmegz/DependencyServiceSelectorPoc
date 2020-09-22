using CustomBase.Attributes;
using CustomBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace CustomApp
{
    public class CustomServiceSelector:ICustomServiceSelector
    {      
        public ICustomService GetCustomService(Type type, IEnumerable<ICustomService> customServices)
        {
            if (type == null) return null;
            if (customServices == null) return null;

            CustomSelectorAttribute tAttribute = type.GetCustomAttribute<CustomSelectorAttribute>();
            if (tAttribute == null) return null;

            foreach (var s in customServices)
            {
                CustomSelectorAttribute sAttribute = s.GetType().GetCustomAttribute<CustomSelectorAttribute>();
                if (sAttribute == null) continue;
                if (tAttribute.Selector == sAttribute.Selector) return s;
            }
            return null;
        }
    }
}
