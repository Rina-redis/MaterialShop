using System;
using System.Collections.Generic;
using System.Text;

namespace polimorphism
{
    class Materials
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }      
        public bool IsInMagazine { get; set; }

        public int GetDiscountPrice(User user)
        {
            if (user.Spent < 300)
            {
                return Price;
            }
            if (user.Spent < 1000)
            {
                return (int)(Price * 0.9);
            }
            return (int)(Price * 0.8);
        }

        public virtual void PrintInfo(Materials material)
        {
            Console.WriteLine(material.Name);
            Console.WriteLine(material.Color);
            Console.WriteLine(material.Price);
            Console.WriteLine(material.IsInMagazine);
        }

    }
}
