using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWebFromMvc.Controllers
{
    [Route("api/[controller]")]
    public class ResourcesController
    {
        private readonly HttpRequest _req;

        //private readonly HttpRequest _req;

        [Activate]
        public ActionContext ActionContext { get; set; }

        public ResourcesController(IHttpContextAccessor ca)
        {
            _req = ca.HttpContext.Request;
        }

        [HttpGet]
        public string Get()
        {
            //return ActionContext.HttpContext.Request.Headers["Accept"];
            return "from using contextaccessor " + _req.Headers["Accept"];
        }
    }
}
