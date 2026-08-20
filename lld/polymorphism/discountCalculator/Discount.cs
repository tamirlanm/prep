using System;
using System.Reflection.Emit;
public abstract class Discount
{   
    protected string Label;
    public Discount(string label) { Label = label;}

    public abstract double Apply(double price);
    public void Describe(double originalPrice)
    {
        Console.WriteLine($"{Label}: ${originalPrice} -> ${Apply(originalPrice):F2}");
    }
}