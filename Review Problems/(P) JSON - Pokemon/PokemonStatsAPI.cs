using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__JSON___Pokemon
{
    class PokemonStatsAPI
    {
        public Info info { get; set; }
    }
    public class Info
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public string FrontDefault { get; set; }
        public string BackDefault { get; set; }

    }
}
