// Продвинутый калькулятор v2.00
using System;

public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"2 + 3 = {Calculator.Add(2, 3)}");
        Console.WriteLine($"2 * 3 = {Calculator.Multiply(2, 3)}");
    }
}
