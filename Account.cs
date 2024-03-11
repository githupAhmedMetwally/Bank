using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Account
    {
        public double Balance { get; set; }
        public string Name { get; set; }

        public Account(double balance=0, string name="null")
        {
            this.Balance = balance;
            this.Name = name;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public bool WithDrow(double amount)
        {
            if (amount>Balance)
            {
                return false;
            } 
                Balance -= amount;
                return true;     
        }
         public void Print()
        {
            Console.WriteLine($"Your Name is: {Name}");
              Console.WriteLine($"Your Balance is: {Balance}");
        }
       
    }
}
