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
    public class PokeviewController : ControllerBase
    {
        private readonly ConnectionSql context;
        public PokeviewController(ConnectionSql context)
        {
            this.context = context;
        }

        // GET: api/<PokeviewController>
        [HttpGet]
        public IEnumerable<PokeView> Get()
        {
            return context.view_poke.ToList();
        }

        [HttpGet("{poke}")]
        public IEnumerable<PokeView> Get(string poke)
        {
            var poked = context.view_poke.Where(p => p.english.Contains(poke));

            return poked.ToList();
        }
        /*
                // GET api/<PokeviewController>/5
                [HttpGet("{id}")]
                public string Get(int id)
                {
                    return "value";
                }*/
    }
}
