using System;

namespace polimorphism
{
    class Laminat : Materials
    {
        public int Long { get; set; }
        public Laminat(string name, string color, int price, bool isinmagazine, int longof) : base(name, color, price, isinmagazine)
        {

            Long = longof;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Длинна" + " " + Long + " метров");
        }
    }
}
