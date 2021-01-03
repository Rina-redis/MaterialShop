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

        public Materials(string name, string color, int price, bool isinmagazine)
        {
            Name = name;
            Color = color;
            Price = price;
            IsInMagazine = isinmagazine;
        }

        public virtual int GetDiscountPrice(User user)
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

        public virtual void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Название: "+Name);
            Console.WriteLine("Цвет: "+Color);
            Console.WriteLine("Цена "+Price);
            if (IsInMagazine)
            {
                Console.WriteLine("Есть в магазине");
            }
            if (!IsInMagazine)
            {
                Console.WriteLine("Нету в магазине");
            }
            
        }

    }
}
