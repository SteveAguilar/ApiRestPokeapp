using Microsoft.EntityFrameworkCore;

namespace PokemonApi.Models
{

    public class Pokedex
    {
        public string? Id { get; set; }
        public string? english { get; set; }
        public string? japanese { get; set; }
        public string? chinese { get; set; }
        public string? french { get; set; }
        public string? type { get; set; }
        public int? HP { get; set; }
        public int? Attack { get; set; }
        public int? Defense { get; set; }
        public int? SpAttack { get; set; }
        public int? SpDefense { get; set; }
        public int? Speed { get; set; }
        public string? Image { get; set; }


    }
}
