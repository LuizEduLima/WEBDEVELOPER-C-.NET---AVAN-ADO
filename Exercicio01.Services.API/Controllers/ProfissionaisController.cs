using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exercicio01.Services.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfissionaisController : ControllerBase
    {

        [HttpGet("{page:int}/{limit:int}")]
        public IActionResult GetAll(int page, int limit)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }

        [HttpPost("")]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut("")]
        public IActionResult Put()
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }

    }
}
