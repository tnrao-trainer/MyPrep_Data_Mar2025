
using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        int sum = 0;

        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            sum += numbers[i];
        }

        Console.WriteLine("Sum of the numbers: " + sum);
    }
}
