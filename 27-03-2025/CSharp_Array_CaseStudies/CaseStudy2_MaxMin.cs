
using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[6];
        Console.WriteLine("Enter 6 numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int max = numbers[0];
        int min = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
                max = num;
            if (num < min)
                min = num;
        }

        Console.WriteLine("Maximum: " + max);
        Console.WriteLine("Minimum: " + min);
    }
}
