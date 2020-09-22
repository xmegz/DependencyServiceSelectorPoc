using System;
using System.Collections.Generic;

namespace CustomBase.Interfaces
{
    public interface ICustomServiceSelector
    {
        public ICustomService GetCustomService(Type type, IEnumerable<ICustomService> customServices);
    }
}
