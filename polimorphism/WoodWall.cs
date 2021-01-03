using System;
using System.Collections.Generic;
using System.Text;

namespace polimorphism
{
    class Wood:Materials
    {
        public string WoodType { get; set; }
        public Wood(string name, string color, int price, bool isinmagazine, string woodtype) : base(name, color, price, isinmagazine)
        {

            WoodType = woodtype;
           
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Тип Дерева:" + " " + WoodType );
        }
    }
}
