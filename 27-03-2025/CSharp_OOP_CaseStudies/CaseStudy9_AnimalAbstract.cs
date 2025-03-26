
using System;

abstract class Animal
{
    public abstract void MakeSound();
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog says: Woof!");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat says: Meow!");
    }
}

class Program
{
    static void Main()
    {
        Animal animal;

        animal = new Dog();
        animal.MakeSound();

        animal = new Cat();
        animal.MakeSound();
    }
}
