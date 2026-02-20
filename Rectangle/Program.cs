
using System;

public class BankAccount
{
    public string Owner { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner, decimal startingBalance)
    {
        Owner = owner;
        Balance = startingBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit must be positive.");
        }

        Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal must be positive.");
        }

        if (amount > Balance)
        {
            return false;
        }

        Balance -= amount;
        return true;
    }

    public override string ToString()
    {
        return $"{Owner}: ${Balance}";
    }
}

public class Program
{
    public static void Main()
    {
        var account = new BankAccount("Alex", 1000m);

        account.Deposit(250m);
        bool success = account.Withdraw(400m);

        Console.WriteLine(account);
        Console.WriteLine($"Withdraw ok? {success}");

    }
}
