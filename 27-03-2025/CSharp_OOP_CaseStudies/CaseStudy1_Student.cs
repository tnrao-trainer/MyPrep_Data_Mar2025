
using System;

class Student
{
    public string Name;
    public int Age;
    public string Grade;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
    }
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();
        student1.Name = "John";
        student1.Age = 20;
        student1.Grade = "A";
        student1.DisplayInfo();
    }
}
