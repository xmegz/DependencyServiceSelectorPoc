using CustomBase.Attributes;
using CustomBase.Interfaces;

namespace CustomServices.Services
{
    [CustomSelector("B")]
    public class BCustomService: ICustomService
    {
        public string GetMessage()
        {
            return nameof(BCustomService) + " Message";
        }
    }
}
