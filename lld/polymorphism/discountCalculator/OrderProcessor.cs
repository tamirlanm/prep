public class OrderProcessor
{
    public void ProcessOrder(string itemName, double price, Discount discount)
    {
        Console.WriteLine($"Item: {itemName}");
        discount.Describe(price);
    }
}