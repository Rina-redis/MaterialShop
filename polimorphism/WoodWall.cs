using System;
using System.Collections.Generic;
using System.Text;

namespace polimorphism
{
    class Wood:Materials
    {
        public string WoodType { get; set; }
        public Wood(string name, string color, int price, bool isinmagazine, string woodtype)
        {
            name = Name;
            color = Color;
            price = Price;
            isinmagazine = IsInMagazine;
            woodtype = WoodType;
           
        }
    }
}
