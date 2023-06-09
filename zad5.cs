using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;

        Console.WriteLine("Podaj pierwszą liczbe");
        a = inputValue();
        Console.WriteLine("Podaj drugą liczbe");
        b = inputValue();
        if (a > b)
        { Console.WriteLine($"Większa liczba to : {a}"); }
        else
        { Console.WriteLine($"Większa liczba to : {b}"); }
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}