
// Продвинутый калькулятор v2.0 (объединённая версия)
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

    /// <summary>
    /// Делит a на b.
    /// </summary>
    ///  Выбрасывается при b = 0
    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Деление на ноль недопустимо");
        }
        return a / b;
    }

}

class Program
{
    static void Main()
    {

        Console.WriteLine($"Результат сложения 2 + 3 = {Calculator.Add(2, 3)}");
    }
}

        Console.WriteLine($"2 + 3 = {Calculator.Add(2, 3)}");
        Console.WriteLine($"2 * 3 = {Calculator.Multiply(2, 3)}");
Console.WriteLine($"2 / 3 = {Calculator.Divide(2, 3)}");
    }
}

