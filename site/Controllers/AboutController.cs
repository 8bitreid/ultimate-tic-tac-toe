using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ultimate_tic_tac_toe.Controllers
{
    [Route("api/[controller]")]
    public class AboutController : Controller
    {
        [HttpGet("[action]")]
        public IActionResult ApiVersion() => Json(new Version("1.0.0"));
    }
    public class Version {
        public string ApiVersion { get; set; }
        public Version(String version)
        {
            ApiVersion = version;
        }
    }
}