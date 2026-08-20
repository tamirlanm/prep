public class PercentageDiscount : Discount
{
    private double _percentage;
    public PercentageDiscount(double percentage) : base($"{percentage:F1}% off")
    {
        _percentage = percentage;
    }

    public override double Apply(double price)
    {
        return price * (1 - (_percentage / 100));
    }
}