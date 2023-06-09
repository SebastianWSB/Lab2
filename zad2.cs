using System;

public class Program
{
    public static void Main(string[] args)
    {
        double wzrost, waga, bmi;

        Console.WriteLine("Podaj swój wzrost (w metrach)");
        wzrost = inputValue();
        Console.WriteLine("Podaj swoją wage");
        waga = inputValue();
        bmi = waga / Math.Pow(wzrost, 2);
        Console.WriteLine($"Twój wskaźnik BMI wynosi:{bmi}");
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}