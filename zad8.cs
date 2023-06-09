using System;

public class Program
{
    public static void Main(string[] args)
    {
        double a, b, c, wynik;

        Console.WriteLine("1 - Dodawanie");
        Console.WriteLine("2 - Odejmowanie");
        Console.WriteLine("3 - Mnożenie");
        Console.WriteLine("4 - Dzielenie");

        Console.WriteLine("Podaj pierwszą liczbe");
        a = inputValue();
        Console.WriteLine("Podaj drugą liczbe");
        b = inputValue();
        Console.WriteLine("Podaj cyfre odpowiadającą działaniu");
        c = inputValue();
        if (c == 1)
        {
            wynik = a + b;
            Console.WriteLine($"Wynik wynosi:{wynik}");
        }
        else if (c == 2)
        {
            wynik = a - b;
            Console.WriteLine($"Wynik wynosi:{wynik}");
        }
        else if (c == 3)
        {
            wynik = a * b;
            Console.WriteLine($"Wynik wynosi:{wynik}");
        }
        else if (c == 4)
        {
            if (b != 0)
            {
                wynik = a / b;
                Console.WriteLine($"Wynik wynosi:{wynik}");
            }
            else
            {
                Console.WriteLine($"Wynik wynosi:{a}/{b}");
            }
        }
        else
        {
            Console.WriteLine("Nie wybrano prawidłowej cyfry działania");
        }
    }

    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}