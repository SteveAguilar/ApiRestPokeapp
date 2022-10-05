using Microsoft.AspNetCore.Mvc;
using PokemonApi.Contexts;
using PokemonApi.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PokemonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypesController : ControllerBase
    {
        private readonly ConnectionSql context;
        public TypesController(ConnectionSql context)
        {
            this.context = context;
        }

        // GET: api/<TypesController>
        [HttpGet]
        public IEnumerable<Types> Get()
        {
            return context.types.ToList();
        }
        /*
                // GET api/<TypesController>/5
                [HttpGet("{id}")]
                public string Get(int id)
                {
                    return "value";
                }

                // POST api/<TypesController>
                [HttpPost]
                public void Post([FromBody] string value)
                {
                }

                // PUT api/<TypesController>/5
                [HttpPut("{id}")]
                public void Put(int id, [FromBody] string value)
                {
                }

                // DELETE api/<TypesController>/5
                [HttpDelete("{id}")]
                public void Delete(int id)
                {
                }*/
    }
}
