
using System;

class Car
{
    public string Model;
    public static int CarCount = 0;

    public Car(string model)
    {
        Model = model;
        CarCount++;
    }

    public static void ShowCarCount()
    {
        Console.WriteLine($"Total Cars Produced: {CarCount}");
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car("Tesla Model S");
        Car car2 = new Car("Ford Mustang");
        Car car3 = new Car("BMW M3");
        Car.ShowCarCount();
    }
}
