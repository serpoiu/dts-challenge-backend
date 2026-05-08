using Microsoft.AspNetCore.Mvc;
using dts_challenge_backend.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dts_challenge_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseTasksController : ControllerBase
    {

        public CaseTask Task { get; set; } = default!;
        // GET: api/<TasksController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TasksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TasksController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TasksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TasksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
