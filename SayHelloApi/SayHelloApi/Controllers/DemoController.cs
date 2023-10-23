    using Microsoft.AspNetCore.Mvc;

namespace SayHelloApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DemoController : Controller
    {
        private readonly ILogger<DemoController> _logger;

        
        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult SayHello (string name)
        {
            string hello = "Hello " + name + "!!";
            return Ok(hello);
        }
    }
}
