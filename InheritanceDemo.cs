using System;

namespace OOP_Assignment
{
    // Base class
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Inheritance and Method Overriding ===");

            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Console.Write("Animal makes sound: ");
            genericAnimal.MakeSound();

            Console.Write("Dog makes sound: ");
            dog.MakeSound();

            Console.Write("Cat makes sound: ");
            cat.MakeSound();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
