using System;
public class BankAccount
{
    protected string OwnerName;
    protected string AccountNumber;
    protected double Balance;

    public BankAccount(string ownerName, string accountNumber, double balance)
    {
        OwnerName = ownerName;
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public bool Deposit(double amount)
    {
        return amount > 0 ? true : false;
    }
    public virtual bool Withdraw(double amount)
    {
        if(Balance >= amount)
        {
            return true;
        }
        return false;
    }
    public void DisplayAccount()
    {
        Console.WriteLine($"{OwnerName} ({AccountNumber}) | Balance: ${Balance:F2}");

    }
}