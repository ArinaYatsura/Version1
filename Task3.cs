using System;

class Task3
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        PrintReverse(array, array.Length - 1);

        Console.ReadKey();
    }

    static void PrintReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintReverse(array, index - 1);
        }
    }
}