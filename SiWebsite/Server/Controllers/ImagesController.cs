using Microsoft.AspNetCore.Http;
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
    public class ImagesController : ControllerBase
    {
        [HttpGet("[action]/{path}")]
        public IActionResult GetImage(string path)
        {
            path = System.Web.HttpUtility.UrlDecode(path);

            string mimeType;

            if (path.EndsWith(".svg"))
            {
                mimeType = "image/svg+xml";
            }
            else if (path.EndsWith(".gif"))
            {
                mimeType = "image/gif";
            }
            else
            {
                mimeType = "image/png";
            }


            return File($"/images/{path}", mimeType, $"{path}");
        }
    }
}
