
using System;

class BankingSystem
{
    static decimal GetBalance()
    {
        decimal b;
        Console.Write("Please, enter your initial balance: ");

        while (!decimal.TryParse(Console.ReadLine(), out b) || b < 0)
        {
            Console.WriteLine("Invalid input. Please enter a POSITIVE number: ");
            Console.Write("Please, enter your initial balance: ");
        }
        if (b != 0)
        {
            Console.WriteLine("Invalid initial balance. Defaulting to 0.");
            b = 0;
        }


        return b;
    }

    static decimal GetAmount()
    {
        decimal amount;
        Console.Write("Please, enter amount: ");

        while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
         {
            Console.WriteLine("Invalid input. Please enter a POSITIVE number: ");
            Console.Write("Please, enter amount: ");
        }

        return amount;
    }

    static void Main()
    {
        {
            Console.WriteLine("HELLO, WELCOME TO JECY INTERNATIONAL BANK.\nHow may I assist you today?\n");
        }

        decimal balance = GetBalance();
        Console.WriteLine("Your initial balance is: " + balance);

        while (true)
        {
            Console.WriteLine("\n1. Deposit  2. Withdraw  3. Check Balance  4. Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            if (choice == "4")
            {
                Console.WriteLine("Goodbye and thank you for banking with us!");
                break;
            }

            if (choice == "3")
            {
                Console.WriteLine("Balance: " + balance);
                continue;
            }

            if (choice != "1" && choice != "2")
            {
                Console.WriteLine("Invalid choice! Please enter a number between 1-4.");
                continue;
            }

            decimal amount = GetAmount();

            if (choice == "1")
            {
                balance += amount;
                Console.WriteLine("Deposited: " + amount + ". New Balance: " + balance);
            }
            else if (choice == "2" && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn: " + amount + ". New Balance: " + balance);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Insufficient funds! Your balance is: " + balance);
            }
        }
    }
}
