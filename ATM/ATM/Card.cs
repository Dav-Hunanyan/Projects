using System;
using System.Collections.Generic;

namespace ATM
{
    class Card
    {
        public string FullName { get; private set; }

        public int Password { get; private set; }

        public int Bill { get; private set; }

        public List<Deal> deals;
        public Card(string name, int password, int money)
        {
            FullName = name;
            Password = password;
            Bill = money;
            deals = new List<Deal>();
        }


        public void Print_name()
        {
            Console.WriteLine($"Fullname: {FullName}");
        }
        public void Print()
        {
            Console.WriteLine($"Fullname: {FullName}\tPassword: {Password}");
        }
        public void Add_money()
        {
            Console.Write("How much money you want to add: ");
            int money = int.Parse(Console.ReadLine());
            if (money > 1000)
            {
                Console.WriteLine("You can't add more than 1000$");
                return;
            }
            Bill += money;
            Console.WriteLine("Process is succsed");
        }
        public void Get_money(int money)
        {
            Bill -= money;
        }
        public int Check_bill()
        {
            return Bill;
        }
        public void Print_deals()
        {
            Console.WriteLine("The previous five transactions");
            foreach (Deal item in deals)
            {
                item.Print();
            }
        }
        public void Add_deal(Deal deal)
        {
            if (deals.Count < 5)
            {
                deals.Add(deal);
            }
            else
            {
                deals.RemoveAt(4);
                deals.Add(deal);
            }
        }


    }
}
