
using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        int evenCount = 0, oddCount = 0;

        Console.WriteLine("Enter 10 numbers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            if (numbers[i] % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine("Even numbers count: " + evenCount);
        Console.WriteLine("Odd numbers count: " + oddCount);
    }
}
