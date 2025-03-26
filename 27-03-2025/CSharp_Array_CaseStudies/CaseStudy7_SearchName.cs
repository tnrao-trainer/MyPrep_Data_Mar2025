
using System;

class Program
{
    static void Main()
    {
        string[] names = new string[5];
        Console.WriteLine("Enter 5 names:");

        for (int i = 0; i < names.Length; i++)
        {
            names[i] = Console.ReadLine();
        }

        Console.Write("\nEnter a name to search: ");
        string searchName = Console.ReadLine();
        bool found = false;

        foreach (string name in names)
        {
            if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine(searchName + " was found!");
        else
            Console.WriteLine(searchName + " was not found.");
    }
}
