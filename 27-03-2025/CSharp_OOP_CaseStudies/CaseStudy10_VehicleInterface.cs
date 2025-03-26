
using System;

interface IVehicle
{
    void Drive();
}

class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Driving a car...");
    }
}

class Bike : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Riding a bike...");
    }
}

class Program
{
    static void Main()
    {
        IVehicle vehicle;

        vehicle = new Car();
        vehicle.Drive();

        vehicle = new Bike();
        vehicle.Drive();
    }
}
