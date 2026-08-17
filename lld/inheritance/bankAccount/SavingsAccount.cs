using System;
public class SavingsAccount : BankAccount
{
    private double _interestRate;
    public SavingsAccount(string ownerName, string accountNumber, double balance, double interestRate) : base(ownerName, accountNumber, balance)
    {
        _interestRate = interestRate;
    }

    public override bool Withdraw(double amount)
    {
        if((Balance - amount) >= 100)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
     public void ApplyInterest()
    {
        Balance += Balance * (_interestRate / 100);
        // TODO: add (Balance * _interestRate / 100) to Balance
    }
}