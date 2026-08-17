public class CheckingAccount : BankAccount
{
    private double _overdraftLimit;

    public CheckingAccount(string ownerName, string accountNumber,
                           double balance, double overdraftLimit)
        : base(ownerName, accountNumber, balance)
    {
        // TODO: initialize _overdraftLimit
        _overdraftLimit = overdraftLimit;
    }

    public override bool Withdraw(double amount)
    {
        // TODO: allow if (Balance + _overdraftLimit) >= amount
        if((Balance + _overdraftLimit) >= amount){
            Balance -= amount;
            return true;
        }
        return false;
    }
}