using System;
using System.Collections.Generic;
using System.Text;

namespace polimorphism
{
    class User
    {
        public string Name { get; private set; }
        public string Adress { get; private set; }
        public int Balance { get; private set; }
        public int Spent { get; private set; }

        public User(string name, string adress, int balance, int spent)
        {
            Name = name;
            Adress = adress;
            Balance = balance;
            Spent = spent;

        }
        public void ReduceBalance(int price)
        {
            Balance -= price;
            Spent += price;
        }

    }
}
