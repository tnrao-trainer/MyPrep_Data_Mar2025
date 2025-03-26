
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

        string longestName = names[0];

        foreach (string name in names)
        {
            if (name.Length > longestName.Length)
                longestName = name;
        }

        Console.WriteLine("The longest name is: " + longestName);
    }
}
