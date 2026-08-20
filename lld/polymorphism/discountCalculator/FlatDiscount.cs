public class FlatDiscount : Discount
{
    private double _amount; 
    public FlatDiscount(double amount) : base($"${amount:F1} off")
    {
        _amount = amount;
    }

    public override double Apply(double price)
    {
        return Math.Max(price - _amount, 0);
    }
}