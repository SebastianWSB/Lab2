using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj pierwszą liczbe");
        a = inputValue();
        Console.WriteLine("Podaj drugą liczbe");
        b = inputValue();
        Console.WriteLine("Podaj trzecią liczbe");
        c = inputValue();

        Console.WriteLine($"Kolejność liczb przed zmianą to {a} {b} {c}");

        (a, b, c) = (b, c, a);

        Console.WriteLine($"Kolejność liczb po zmianie to {a} {b} {c}");
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}