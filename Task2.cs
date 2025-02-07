using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите неотрицательное число M:");
        int m = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите неотрицательное число N:");
        int n = int.Parse(Console.ReadLine());
        
        int result = Ackermann(m, n);
        Console.WriteLine($"Функция Аккермана для A({m}, {n}) = {result}");
    }
    
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        return -1; // Этот случай никогда не произойдет, так как m и n неотрицательные
    }
}