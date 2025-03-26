
using System;

class Program
{
    static void Main()
    {
        int[] originalArray = new int[5];
        int[] copiedArray = new int[5];

        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < originalArray.Length; i++)
        {
            originalArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < originalArray.Length; i++)
        {
            copiedArray[i] = originalArray[i];
        }

        Console.WriteLine("Copied Array Elements:");
        foreach (int num in copiedArray)
        {
            Console.Write(num + " ");
        }
    }
}
