public class Circle : Shape
{
    private double _radius;
    public Circle(double radius) : base("Circle")
    {
        _radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
    public override double Perimeter()
    {
        return 2 * Math.PI * _radius;
    }
}