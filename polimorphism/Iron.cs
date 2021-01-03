using System;
using System.Collections.Generic;
using System.Text;

namespace polimorphism
{
    class Iron:Materials
    {
        public int Strength { get; set; }
        public Iron(string name, string color, int price, bool isinmagazine,int strength) : base(name, color, price, isinmagazine)
        {

            Strength = strength;

        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Жёсткость" + " " + Strength + " джоулей");
        }

        public override int GetDiscountPrice(User user)
        {
            return Price / 2; // действует скидка на всё железо в 2 раза
        }
    }
}
