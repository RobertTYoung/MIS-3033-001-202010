using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _P__MVC___Beginner.Models
{
    public class PokemonAPI
    {
        public List<Pokemon> results { get; set; }
    }
    public class Pokemon
    {
        public string name { get; set; }
        public string url { get; set; }

        //public override string ToString()
        //{
        //    return name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1);
        //}
    }
}