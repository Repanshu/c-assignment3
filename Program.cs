using System;

public class Account
{
    public string AccountNumber { get; }
    public double Balance { get; private set; }
    public string AccountType { get; }

    public Account(string accountNumber)
    {
        AccountNumber = accountNumber;
        Balance = 0;
        AccountType = "checking";
    }

    public Account(string accountNumber, double balance, string accountType)
    {
        AccountNumber = accountNumber;
        Balance = balance;
        AccountType = accountType;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
        }
    }

    public void Deposit(params double[] amounts)
    {
        foreach (double amount in amounts)
        {
            Deposit(amount);
        }
    }

    public void Withdraw(params double[] amounts)
    {
        foreach (double amount in amounts)
        {
            Withdraw(amount);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Account checkingAccount = new Account("123456789");

        Account savingsAccount = new Account("987654321", 1000, "savings");

        checkingAccount.Deposit(6969);

        savingsAccount.Withdraw(609);

        checkingAccount.Withdraw(300, 100);

        Console.WriteLine("Checking Account Balance: $" + checkingAccount.Balance);
        Console.WriteLine("Savings Account Balance: $" + savingsAccount.Balance);
    }
}