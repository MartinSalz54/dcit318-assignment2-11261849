using System;

namespace OOP_Assignment
{
    // Interface definition
    interface IMovable
    {
        void Move();
    }

    // Class that implements IMovable
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Another class that implements IMovable
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Interfaces ===");

            IMovable car = new Car();
            IMovable bicycle = new Bicycle();

            car.Move();
            bicycle.Move();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
