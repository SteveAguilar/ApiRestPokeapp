using Microsoft.EntityFrameworkCore;
using PokemonApi.Models;

namespace PokemonApi.Contexts
{
    public class ConnectionSql:DbContext
    {

        public ConnectionSql(DbContextOptions options) : base(options)
        { 
        
        //

        }

        public DbSet<Moves> moves { get; set; }
        public DbSet<Items> items { get; set; }
        public DbSet<Pokedex> pokedex { get; set; }
        public DbSet<Types> types { get; set; }
        public DbSet<PokeView> view_poke { get; set; }

    }
}
