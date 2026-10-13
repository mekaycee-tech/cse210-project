public class Rectangle : Shape
{
    private double _length;
    private double _width;

    // Call base constructor to set color
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }

    // Override GetArea for a rectangle: length * width
    public override double GetArea()
    {
        return _length * _width;
    }
}