using System;
public class Shape
{
    protected string Name;
    public Shape(string name) {Name = name;}

    public virtual double Area()
    {
        return 0;
    }
    public virtual double Perimeter()
    {
        return 0;
    }
    public void Describe()
    {
        Console.WriteLine($"Shape: {Name}, Area: {Area():F2}, Perimeter: {Perimeter():F2}");
    }
}