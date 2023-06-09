using System;

public class Program
{
    public static void Main(string[] args)
    {
        int a, b, c, d, x, y;

        Console.WriteLine("Podaj a");
        a = inputValue();
        Console.WriteLine("Podaj b");
        b = inputValue();
        Console.WriteLine("Podaj c");
        c = inputValue();
        Console.WriteLine("Podaj d");
        d = inputValue();
        if (b == 0 || d == 0)
        { Console.WriteLine("Brak rozwiązań"); }
        else
        {
            x = a * d + c * b;
            y = b * d;
            Console.WriteLine($"X wynosi:{x}, a Y wynosi:{y}");
        }
    }

    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}