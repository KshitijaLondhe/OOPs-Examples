using System;
/*1. Write a C# program to create an abstract class BankAccount with 
    abstract methods deposit() and withdraw().
Create subclasses: SavingsAccount and CurrentAccount that inherit the BankAccount class 
and implement the respective methods to handle deposits and withdrawals for each account type.
*/

namespace InheritanceExamples
{
    public abstract class BankAccount
    {
        public abstract void deposit(double amount);
        public abstract void withdraw(double amount);
    }

    public class SavingsAccount : BankAccount
    {
        double amount;
        double balance = 1000;
     
        public override void deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
            }
            else {
                Console.WriteLine("Enter amount more than zero");
            }
        }

        public override void withdraw(double amount)
        {
            if (amount > 0 && amount<balance)
            {
                balance = balance -amount;
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }

        public override string ToString()
        {
            return $"Available Balance:{balance}";
        }
    }

    public class CurrentAccount : BankAccount
    {
        double amount;
        double balance = 2000;

        public override void deposit(double amount)
        {
            if (amount > 0)
            {
                balance = balance + amount;
            }
            else
            {
                Console.WriteLine("Enter amount more than zero");
            }
        }

        public override void withdraw(double amount)
        {
            if (amount > 0 && amount < balance)
            {
                balance = balance - amount;
            }
            else
            {
                Console.WriteLine("Insufficient Funds");
            }
        }

        public override string ToString()
        {
            return $"Available Balance:{balance}";
        }
    }
}
