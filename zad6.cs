using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;

        Console.WriteLine("Podaj pierwszy bok trójkąta");
        a = inputValue();
        Console.WriteLine("Podaj drugi bok trójkąta");
        b = inputValue();
        Console.WriteLine("Podaj trzeci bok trójkąta");
        c = inputValue();
        if (a == b)
        {
            if (b == c)
            { Console.WriteLine("Trójkąt jest równoboczny"); }
            else
            { Console.WriteLine("Trójkąt nie jest równoboczny"); }
        }
        else
        { Console.WriteLine("Trójkąt nie jest równoboczny"); }
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}