
using System;

class Employee
{
    public string Name;
    public double Salary;

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Salary: {Salary}");
    }
}

class Manager : Employee
{
    public string Department;

    public void DisplayManager()
    {
        Display();
        Console.WriteLine($"Department: {Department}");
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager();
        manager.Name = "Alice";
        manager.Salary = 90000;
        manager.Department = "IT";
        manager.DisplayManager();
    }
}
