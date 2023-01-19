using Microsoft.AspNetCore.Mvc;

namespace Nop.Plugin.CompanyName.Api
{
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet("CompanyName/hello")]
        public IActionResult Index()
        {
            return Content("Hello World!", "text/plain");
        }
    }
}
