using System;
using System.Collections.Generic;
using System.Text;

namespace polimorphism
{
    class Informer
    {
        public void Buy(User user, Materials material)
        {
            int Price = material.GetDiscountPrice(user);
            if (CanBuy(user,material,Price)) 
            {
                user.ReduceBalance(Price);
                Console.WriteLine($"{user.Name} купил {material.Name } за {Price} гривен");
            }
            if (!material.IsInMagazine)
            {
                Console.WriteLine($"Товара {material.Name} нет в наличии");
            }
            if(user.Balance<Price)
            {
                Console.WriteLine($"{user.Name} имеет недостаточно средстств для покупки  {material.Name } за {Price} гривен ");
            }

        }

        public bool CanBuy(User user, Materials material, int price) 
        {
            if (material.IsInMagazine == true && user.Balance >= price)
                return true;
            else
                return false;
        }
    }
}
