using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__JSON___Chuck_Norris_Jokes
{
    class ChuckNorrisAPI
    {
        public List<Category> results { get; set; }
    }
    public class Category
    { 
        public string value { get; set; }
    }
}
