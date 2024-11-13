using System;

class Task1
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        PrintNumbers(M, N);

        Console.ReadKey();
    }

    static void PrintNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.WriteLine(M);
            PrintNumbers(M + 1, N);
        }
    }
}