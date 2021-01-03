using System;

namespace polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Олег", "Вишнёвое", 300, 0);

            Informer informer = new Informer();

            Laminat laminat = new Laminat("Ламинат Обычный","Коричневый",30,true,55);
            Iron iron = new Iron("Железо обычное", "Белое", 90, true, 40); 
            Wood birch = new Wood("Берёза", "Чёрно-белый",10, false,"Берёза");
            Laminat officeLaminat = new Laminat("Ламинат Офиссный", "Серый", 50, true, 35);
            Iron rareIron = new Iron("Железо старое", "Белое с потёртостями", 60, true, 20);
            Wood oak = new Wood("Дуб", "Коричневый", 10, false, "Дуб");

            Materials[] mats = { laminat, iron, birch, officeLaminat,rareIron,oak };

            foreach (Materials mat in mats)
            {
                mat.PrintInfo();
            }

            informer.Buy(user, birch);
            informer.Buy(user, rareIron);

        }
    }
}
