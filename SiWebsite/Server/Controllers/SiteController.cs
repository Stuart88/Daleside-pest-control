using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SiWebsite.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("[action]")]
        public IActionResult GetImage([FromRoute]string src)
        {
            return File(Path.Combine("wwwroot", "imaes", src), "image/jpeg");
        }
    }
}
