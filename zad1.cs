using System;

public class Program
{
    public static void Main(string[] args)
    {
        double promien, pole, obwod;
        Console.WriteLine("Podaj pole");
        pole = inputValue();
        promien = Math.Sqrt(pole / Math.PI);
        obwod = 2 * promien * Math.PI;
        Console.WriteLine($"Obwód koła wynosi:{obwod}");
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}