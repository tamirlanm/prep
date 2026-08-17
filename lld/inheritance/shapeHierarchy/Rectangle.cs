public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(double width, double height) : base("Rectangle")
    {
        _width = width;
        _height = height;
    }

    public override double Area()
    {
        return _width * _height;
    }

    public override double Perimeter()
    {
        return 2 * (_height + _width);
    }
}