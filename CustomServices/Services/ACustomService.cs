using CustomBase.Attributes;
using CustomBase.Interfaces;

namespace CustomServices.Services
{
    [CustomSelector("A")]
    public class ACustomService : ICustomService
    {
        public string GetMessage()
        {
            return nameof(ACustomService) + " Message";
        }
    }
}
