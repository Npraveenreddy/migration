using Microsoft.AspNetCore.Mvc;

namespace Portal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to the Portal API");
        }
    }
}

