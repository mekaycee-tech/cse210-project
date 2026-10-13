public class Shape
{
    private string _color;

    // Constructor to set the color
    public Shape(string color)
    {
        _color = color;
    }

    // Getter for color
    public string GetColor()
    {
        return _color;
    }

    // Setter for color
    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual method to allow overriding in derived classes
    public virtual double GetArea()
    {
        return 0;
    }
}