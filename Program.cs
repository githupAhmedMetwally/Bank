namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {  

            Account account = new Account(name:"Ahmed");
            

            do
            {
               
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Print");
                Console.WriteLine("4. Quit");

                Console.Write("Please select an option:");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        DoDeposit(account);
                        break;
                    case 2:
                        DoWithdraw(account);
                        break;
                    case 3:
                        DoPrint(account);
                        break;
                    case 4:
                        return;
                        Console.WriteLine("Goodbey");
                }


            } while (true);

          

           
        }
        public static void DoDeposit(Account account)
        {
            Console.WriteLine("Please enter the amount to deposit:");
            double amount = double.Parse(Console.ReadLine());

            account.Deposit(amount);

            Console.WriteLine("Deposit successful!");
        }
        public static void DoWithdraw(Account account)
        {
            Console.WriteLine("Please enter the amount to withdraw:");
            double amount = double.Parse(Console.ReadLine());

            if (!account.WithDrow(amount))
            {
                Console.WriteLine("Insufficient funds!");
                return;
            }

            Console.WriteLine("Withdrawal successful!");
        }
        public static void DoPrint(Account account)
        {
            account.Print();
        }

    }
}

