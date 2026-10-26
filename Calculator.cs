public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine($"Результат сложения 2 + 3 = {Calculator.Add(2, 3)}");
    }
}