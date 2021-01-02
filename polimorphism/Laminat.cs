using System;
using System.Collections.Generic;
using System.Text;

namespace polimorphism
{
    class Laminat:Materials
    {
        public int Long { get; set; }
        public Laminat(string name, string color, int price, bool isinmagazine, int longof)
        {
            name = Name;
            color = Color;
            price = Price;
            isinmagazine = IsInMagazine;
            longof = Long;
        }

        public override void PrintInfo(Materials material):base
        {
            base.PrintInfo(material);
            Console.WriteLine("Длинна" + " "+ Long+"метров");
        }
    }
}
