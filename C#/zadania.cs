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
                Console.WriteLine("2. Konwerter temperatur");
                Console.WriteLine("3. Średnia ocen ucznia");
                Console.WriteLine("0. Wyjście");
                Console.Write("Wybierz zadanie (0-3): ");

                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        Zadanie1_Kalkulator();
                        break;
                    case "2":
                        Zadanie2_Temperatura();
                        break;
                    case "3":
                        Zadanie3_Oceny();
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
        static void Zadanie2_Temperatura()
        {
            Console.WriteLine("\n--- Zadanie 2: Konwerter Temperatur ---");
            Console.Write("Wybierz konwersję (C - Celsjusz na Fahrenheit, F - Fahrenheit na Celsjusz): ");
            string kierunek = Console.ReadLine().ToUpper();

            try
            {
                if (kierunek == "C")
                {
                    Console.Write("Podaj temperaturę w Celsjuszach: ");
                    double c = double.Parse(Console.ReadLine());
                    double f = c * 1.8 + 32;
                    Console.WriteLine($"{c}°C = {f:F2}°F");
                }
                else if (kierunek == "F")
                {
                    Console.Write("Podaj temperaturę w Fahrenheitach: ");
                    double f = double.Parse(Console.ReadLine());
                    double c = (f - 32) / 1.8;
                    Console.WriteLine($"{f}°F = {c:F2}°C");
                }
                else
                {
                    Console.WriteLine("Nieznany wybór konwersji.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: Podano nieprawidłową wartość.");
            }
        }
         static void Zadanie3_Oceny()
        {
            Console.WriteLine("\n--- Zadanie 3: Średnia ocen ucznia ---");
            try
            {
                Console.Write("Ile ocen chcesz wprowadzić? ");
                int iloscOcen = int.Parse(Console.ReadLine());
                double suma = 0;

                for (int i = 0; i < iloscOcen; i++)
                {
                    Console.Write($"Podaj ocenę nr {i + 1} (skala 1-6): ");
                    double ocena = double.Parse(Console.ReadLine());
                    suma += ocena;
                }

                if (iloscOcen > 0)
                {
                    double srednia = suma / iloscOcen;
                    Console.WriteLine($"Średnia: {srednia:F2}"); // F2 formatuje do 2 miejsc po przecinku

                    if (srednia >= 3.0)
                    {
                        Console.WriteLine("Uczeń zdał.");
                    }
                    else
                    {
                        Console.WriteLine("Uczeń nie zdał.");
                    }
                }
                else
                {
                    Console.WriteLine("Nie wprowadzono żadnych ocen.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Błąd: Wprowadzono niepoprawne dane.");
            }
            }
    }
}