﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__WPF___Classes_2
{
    class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Aisle { get; set; }

        Toy ()
        {

        }
        string GetAisle()
        {
            string M = Manufacturer - Manufacturer.Length;

            string StringPrice = Convert.ToString(Price);
            string P = StringPrice.Trim(new Char[] { ',', '$', '.' });  //Looked at microsoft trim and removing characters page
            string Aisle = M + P;
            return Aisle;
        }

    }
}
