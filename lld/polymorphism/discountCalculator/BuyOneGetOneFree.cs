public class BuyOneGetOneFree : Discount
{
    public BuyOneGetOneFree() : base("Buy 1 Get 1 Free") {}

    public override double Apply(double price)
    {
        return price / 2;
    }
}