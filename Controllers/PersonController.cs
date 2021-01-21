using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonAPI.Controllers.Services;
using PersonAPI.Model;

namespace PersonAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController: ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger,IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_personService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindByID(id);

            if (person == null) return NotFound();

            return Ok(person);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return BadRequest("Invalid input");
            return Ok(_personService.Create(person));
        }

        
        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if(person == null) return BadRequest("Invalid input");
            return Ok(_personService.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            if (id == 0) BadRequest("Invalid input");
            _personService.Delete(id);
            return NoContent();
        }



    }
}