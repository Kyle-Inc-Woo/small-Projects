using System.Net;

namespace BackAccountSystem;

public class BankAccount
{
    private double balance {get; set;}
    private string accountNumber {get; set;}
    private string owner {get; set;}


    public BankAccount(double balance, string accountNumber, string owner)
    {
        this.balance = balance;
        this.accountNumber = accountNumber;
        this.owner = owner;
    }

    public string Deposit(double amount)
    {

        if (amount > 0)
        {
            balance += amount;
            return $"The balance : ${balance}";
        }
        else
        {
            return $"invalid deposit amount";
        }
    }

    public string Withdraw(double amount)
    {
        
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            return $"The balance : ${balance}";
        }
        else if (amount > balance)
        {
            return $"Insufficient funds. Current balance: ${balance}";
        }
        else
        {
            return $"invalid withdraw amount";
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine("$Current balance: {0:C2}", balance);
    }

    public override string ToString()
    {
        return $"Account number: {accountNumber}\n " +
               $"Account owner : {owner}\n " +
               $"balance       : {balance:C2}";
    }
}