﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__JSON___Pokemon
{
    class PokemonNameAPI
    {
        public List<Pokemon> results{ get; set; }
    }
    public class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
