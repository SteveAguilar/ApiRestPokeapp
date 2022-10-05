using Microsoft.AspNetCore.Mvc;
using PokemonApi.Contexts;
using PokemonApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokedexController : ControllerBase
    {
        private readonly ConnectionSql context;
        public PokedexController(ConnectionSql context)
        {
            this.context = context;
        }

        // GET: api/<TypesController>
        [HttpGet]
        public IEnumerable<Pokedex> Get()
        {
            return context.pokedex.ToList();
        }

        [HttpGet("{poke}")]
        public Pokedex Get(string poke)
        {
            var poked = context.pokedex.FirstOrDefault(p => p.english.Contains(poke));

            return poked;
        }
    }
}
