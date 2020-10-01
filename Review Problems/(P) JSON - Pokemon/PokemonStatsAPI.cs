using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__JSON___Pokemon
{
    class PokemonStatsAPI
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public sprite sprites { get; set; }
    }
    public class sprite 
    { 
        public string front_default { get; set; }
        public string back_default { get; set; }
    }
}
