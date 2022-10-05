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
    public class ItemsController : ControllerBase
    {
        private readonly ConnectionSql context;
        public ItemsController(ConnectionSql context)
        {
            this.context = context;
        }

        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<Items> Get()
        {
            return context.items.ToList();
        }

        [HttpGet("{id}")]
        public dynamic Get(int id)
        {
            return context.items.Find(id);
        }

        /*
                // GET api/<ItemsController>/5

                // POST api/<ItemsController>
                [HttpPost]
                public void Post([FromBody] string value)
                {
                }

                // PUT api/<ItemsController>/5
                [HttpPut("{id}")]
                public void Put(int id, [FromBody] string value)
                {
                }

                // DELETE api/<ItemsController>/5
                [HttpDelete("{id}")]
                public void Delete(int id)
                {
                }*/
    }
}
