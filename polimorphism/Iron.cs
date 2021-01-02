using System;
using System.Collections.Generic;
using System.Text;

namespace polimorphism
{
    class Iron:Materials
    {
        public string Strength { get; set; }
        public Iron(string name, string color, int price, bool isinmagazine, string strength)
        {
            name = Name;
            color = Color;
            price = Price;
            isinmagazine = IsInMagazine;
            strength = Strength;

        }
    }
}
