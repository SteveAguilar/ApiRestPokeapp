using Microsoft.EntityFrameworkCore;

namespace PokemonApi.Models
{
    [Keyless]
    public class Types
    {
        public string? english { get; set; }
        public string? chinese { get; set; }
        public string? japanese { get; set; }

        public string? color { get; set; }
    }
}
