using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P__Classes_3
{
    class Address
    {
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public int Zipcode { get; set; }

        Address()
        { 
        
        }

        Address(int streetnumber, string streetname, string state, string city, int zipcode)
        {
            StreetNumber = streetnumber;
            StreetName = streetname;
            State = state;
            City = city;
            Zipcode = zipcode;
        }
    }
}
