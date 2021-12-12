using System;
using System.Threading;

//1.Simple ATM Software
//This simple project will essentially create a simulation of an ATM within a Windows program. Just like an ATM, the program should have at least the following features:

//Checking whether an input – such as an ATM card (a debit/credit card number) – is recorded correctly
//In case of negative verification, logging out the user
//In case of positive verification, showing multiple options, including cash availability, the previous five transactions, and cash withdrawal
//Giving the user the ability to withdraw up to $1,000 worth of cash in one transaction, with total transactions limited to ten per day.
//a “fast” cash withdrawal system for quickly withdrawing $20, $50, or $100.

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            Cards cards = new Cards();

            do
            {
                Command: Console.Write("1.Creat card 2.Use card 3.Exit   : ");
                string command = Console.ReadLine();
                Console.WriteLine();
                switch (command)
                {
                    case "1":
                        Console.Write("Full Name: ");
                        string fullname = Console.ReadLine();
                        Password: Console.Write("Password(from 1000 to 9999): ");
                        int password = int.Parse(Console.ReadLine());
                        if (password < 1000 || password > 9999)
                        {
                            Console.WriteLine("Please enter valid password");
                            goto Password;
                        }
                        cards.cards.Add(new Card(fullname, password, 1000));
                        Console.WriteLine("Your card is created");
                        break;
                    case "2":
                        cards.Print();
                        Console.Write("Choose card : ");
                        int choose = int.Parse(Console.ReadLine());
                        cards.cards[choose - 1].Print();
                        Console.WriteLine("1.Add money  2.ATM");
                        string use = Console.ReadLine();
                        switch (use)
                        {
                            case "1":
                                cards.cards[choose - 1].Add_money();
                                break;
                            case "2":

                                if (atm.Check_password(cards.cards[choose - 1]))
                                {
                                    Console.WriteLine("1.Check Bill  2.Remove Money  3.Print last deals");
                                    string command2 = Console.ReadLine();
                                    switch (command2)
                                    {
                                        case "1":
                                            atm.Check_Bill(cards.cards[choose - 1]);
                                            break;
                                        case "2":
                                            atm.Remove_money(cards.cards[choose - 1]);
                                            break;
                                        case "3":
                                            atm.Print_Deals(cards.cards[choose - 1]);
                                            Console.ReadKey();
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Bye");
                        return;
                    default:
                        Console.WriteLine("Wrong command");
                        goto Command;

                }
                Thread.Sleep(2000);
                Console.Clear();
            } while (true);
        }
    }
}
