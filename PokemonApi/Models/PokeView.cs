using Microsoft.EntityFrameworkCore;

namespace PokemonApi.Models
{
    [Keyless]
    public class PokeView
    {
        public string? Pid { get; set; }
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
        public string? image { get; set; }
        public string? tenglish { get; set; }
        public string? tjapanese { get; set; }
        public string? tchinese { get; set; }
        public string? tcolor { get; set; }
    }
}
