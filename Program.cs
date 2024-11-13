int firstnumber = 10;
int secondnumber = 3;

// string str = firstnumber + " , b = " + secondnumber;
if (firstnumber % secondnumber == 0) // true
{
    System.Console.WriteLine("Делится");
}
else
{
    System.Console.WriteLine("Не делится");
}

//// 2 задача

using System;
public class Answer
{
    static int FindMedian(int a, int b, int c)
    {
        int middleNumber = FindMiddleNumber(firstNumber, secondNumber, thirdNumber);

        Console.WriteLine($"Среднее число: {middleNumber}");
    }
    static public void Main(string[] args)

int a, b, c;
if (args.Length >= 3)
{
a = int.Parse(args[0]);
    b = int.Parse(args[1]);
    c = int.Parse(args[2]);
}
  else
{
    a = 5;
    b = 3;
    c = 8;
}
int result = FindMedian(a, b, c);
System.Console.WriteLine($"{result}");

/// 3 задача
 /// 
using System;
class Answer
{
    static void CheckNumber(int number)
    {
        CheckNumberSign(number);
    }
    public static void CheckNumberSign(int number)
   
if (number > 0)
{
Console.WriteLine("Число положительное");
 }
 else if (number < 0)
{
Console.WriteLine("Число отрицательное");
}
else
{
    Console.WriteLine("Число равно нулю");
}

