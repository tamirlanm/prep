public class Program
{
    public static void Main()
    {
        var savings = new SavingsAccount("Alice", "SAV-001", 1000, 2.0);
        savings.DisplayAccount();
        Console.WriteLine("Withdraw $950: " + savings.Withdraw(950).ToString().ToLower());
        savings.ApplyInterest();
        savings.DisplayAccount();

        Console.WriteLine();

        var checking = new CheckingAccount("Bob", "CHK-002", 500, 300);
        checking.DisplayAccount();
        Console.WriteLine("Withdraw $700: " + checking.Withdraw(700).ToString().ToLower());
        checking.DisplayAccount();
    }
}