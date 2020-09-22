using CustomBase.Attributes;
using CustomBase.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomControllers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [CustomSelector("B")]
    public class CController : ControllerBase
    {
        private readonly ICustomService _customService;

        public CController(ICustomServiceSelector customServiceSelector, IEnumerable<ICustomService> customServices)
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
