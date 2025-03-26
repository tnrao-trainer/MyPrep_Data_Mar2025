
using System;

class Product
{
    public string Name;
    public double Price;

    public Product()
    {
        Name = "Unknown";
        Price = 0.0;
    }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine($"Product: {Name}, Price: ${Price}");
    }
}

class Program
{
    static void Main()
    {
        Product product1 = new Product();
        Product product2 = new Product("Laptop", 1200.99);
        product1.Display();
        product2.Display();
    }
}
