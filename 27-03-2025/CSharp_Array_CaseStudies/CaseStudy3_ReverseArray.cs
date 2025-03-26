
using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[7];
        Console.WriteLine("Enter 7 numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Reversed Array:");
        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}
