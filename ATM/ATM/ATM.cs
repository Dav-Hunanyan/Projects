using System;

namespace ATM
{
    class ATM
    {
        private int Money;
        public ATM()
        {
            Money = 10000000;
        }

        public bool Check_password(Card card)
        {
            Console.Write("Please enter password: ");
            int password = int.Parse(Console.ReadLine());
            try
            {
                if (password != card.Password)
                {
                    throw new Exception("Oops,Wrong password");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public void Check_Bill(Card card)
        {
            Console.WriteLine("Your bill: " + card.Check_bill());
        }
        public void Remove_money(Card card)
        {
            Console.WriteLine("How much money you want to remove");
            Command: Console.WriteLine("1.20$  2.50$  3.100$  4.Input sum");
            string command = Console.ReadLine();
            int money;
            switch (command)
            {
                case "1":
                    money = 20;
                    break;
                case "2":
                    money = 50;
                    break;
                case "3":
                    money = 100;
                    break;
                case "4":
                    Console.Write("Input sum: ");
                    money = int.Parse(Console.ReadLine());
                    if (money > 1000)
                    {
                        Console.WriteLine("You can't remove more than 1000$");
                        goto Command;
                    }
                    break;
                default: goto Command;
            }

            try
            {
                if (card.Check_bill() < money)
                {
                    throw new Exception("Oops,You havn't got so much money");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            card.Get_money(money);
            Console.WriteLine("Process is succsed");
            Money -= money;
            card.Add_deal(new Deal(money));

        }
        public void Print_Deals(Card card)
        {
            card.Print_deals();
        }

    }
}
