using System;

namespace OOP_Assignment
{
    // Abstract base class
    abstract class Shape
    {
        public abstract double GetArea();
    }

    // Derived class: Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class: Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Abstract Classes and Methods ===");

            Shape circle = new Circle(5); // radius = 5
            Shape rectangle = new Rectangle(4, 6); // width = 4, height = 6

            Console.WriteLine($"Area of Circle: {circle.GetArea():F2}");
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea():F2}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
