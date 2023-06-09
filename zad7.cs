using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, r, p;

        Console.WriteLine("Podaj pierwszą współrzędną punktu");
        x = inputValue();
        Console.WriteLine("Podaj drugą współrzędną punktu");
        y = inputValue();
        Console.WriteLine("Podaj promień okręgu");
        r = inputValue();

        p = Math.Pow(x, 2) + Math.Pow(y, 2);
        if (Math.Pow(r, 2) == p)
        { Console.WriteLine($"Punkt o współrzędnych ({x},{y}) leży w obrębie koła"); }
        else
        { Console.WriteLine($"Punkt o współrzędnych ({x},{y}) nie leży w obrębie koła"); }
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}