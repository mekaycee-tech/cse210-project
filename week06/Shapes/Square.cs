public class Square : Shape
{
    private double _side;

    // Call the base class constructor to set color
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // Override GetArea for a square: side * side
    public override double GetArea()
    {
        return _side * _side;
    }
}