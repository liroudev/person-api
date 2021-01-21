using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PersonAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController: ControllerBase
    {

        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult GetAction()
        {
            return BadRequest("Invalid input");
        }
        
    }
}