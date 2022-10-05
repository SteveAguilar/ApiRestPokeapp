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
    public class MovesController : ControllerBase
    {
        private readonly ConnectionSql context;
        public MovesController(ConnectionSql context)
        {
            this.context = context;
        }


        // GET: api/<MovesController>
        [HttpGet]
        public IEnumerable<Moves> Get()
        {
            return context.moves.ToList();
        }

        // GET api/<MovesController>/5
        [HttpGet("{id}")]
        public dynamic Get(int id)
        {
            return context.moves.Find(id);
        }

        /*

                // POST api/<MovesController>
                [HttpPost]
                public void Post([FromBody] string value)
                {
                }

                // PUT api/<MovesController>/5
                [HttpPut("{id}")]
                public void Put(int id, [FromBody] string value)
                {
                }

                // DELETE api/<MovesController>/5
                [HttpDelete("{id}")]
                public void Delete(int id)
                {
                }*/
    }
}
