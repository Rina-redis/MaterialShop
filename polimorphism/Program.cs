using System;

namespace polimorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Олег", "Вишнёвое", 300, 0);
            Laminat laminat = new Laminat("Ламинат Обычный", "Коричневый", 30, true, 15);
            laminat.PrintInfo(laminat);
        }
    }
}
