public class Circle : Shape
{
    private double _radius;

    // Call base constructor to set color
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Override GetArea for a circle: pi * r^2
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}