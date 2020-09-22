using CustomBase.Attributes;
using CustomBase.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomControllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [CustomSelector("A")]
    public class AController : ControllerBase
    {
        private readonly ICustomService _customService;

        public AController(ICustomServiceSelector customServiceSelector, IEnumerable<ICustomService> customServices)
        {
            this._customService = customServiceSelector?.GetCustomService(this.GetType(), customServices);
        }

        [HttpGet]
        public string Get()
        {
            return this._customService?.GetMessage();
        }
    }
}
