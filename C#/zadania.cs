using System;

namespace Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n MENU ");
                Console.WriteLine("1. Prosty kalkulator");
                Console.WriteLine("0. Wyjście");
                Console.Write("Wybierz zadanie (0-1): ");

                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        Zadanie1_Kalkulator();
                        break;
                    case "0":
                        running = false;
                        Console.WriteLine("Zamykanie programu...");
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór, spróbuj ponownie.");
                        break;
                }
            }
        }

        static void Zadanie1_Kalkulator()
        {
            Console.WriteLine("\n--- Zadanie 1: Prosty Kalkulator ---");
            try
            {
                Console.Write("Podaj pierwszą liczbę: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Podaj drugą liczbę: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Wybierz operację (+, -, *, /): ");
                string op = Console.ReadLine();

                double wynik = 0;
                bool success = true;

                if (op == "+") wynik = a + b;
                else if (op == "-") wynik = a - b;
                else if (op == "*") wynik = a * b;
                else if (op == "/")
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Błąd: Nie można dzielić przez zero!");
                        success = false;
                    }
                    else
                    {
                        wynik = a / b;
                    }
                }
                else
                {
                    Console.WriteLine("Nieznana operacja.");
                    success = false;
                }

                if (success)
                {
                    Console.WriteLine($"Wynik: {wynik}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: Podano nieprawidłową liczbę.");
            }
        }
    }
}