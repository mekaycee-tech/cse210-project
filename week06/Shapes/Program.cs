using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // Create individual shape instances
        Square s1 = new Square("Red", 5);
        Rectangle r1 = new Rectangle("Blue", 4, 6);
        Circle c1 = new Circle("Green", 3);

        // Add shapes to the list
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        // Display results using polymorphism
        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }
    }
}