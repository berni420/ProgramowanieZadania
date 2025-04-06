using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("ZADANIE 1: kalkulator");
            Console.WriteLine("ZADANIE 2: konwerter temperatur");
            Console.WriteLine("ZADANIE 3: srednia ocen");
            Console.WriteLine("0: exit");
            Console.Write("wybierz numer zadania: ");

            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1": Kalkulator(); break;
                case "2": Konwerter(); break;
                case "3": SredniaOcen(); break;
                case "0": Console.WriteLine("Zamykanie programu..."); return;
                default: Console.WriteLine("Error"); break;
            }
        }
    }

    static void Kalkulator()
    {
        Console.WriteLine("ZADANIE 1: kalkulator");
        Console.Write("podaj pierwsza liczbe: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("podaj druga liczbe: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("wybierz operację (+, -, *, /): ");
        string op = Console.ReadLine();

        double wynik = 0;
        bool ok = true;

        switch (op)
        {
            case "+": wynik = a + b; break;
            case "-": wynik = a - b; break;
            case "*": wynik = a * b; break;
            case "/":
                if (b != 0) wynik = a / b;
                else { Console.WriteLine("nie dziel przez zero!"); ok = false; }
                break;
            default:
                Console.WriteLine("error"); ok = false;
                break;
        }

        if (ok)
            Console.WriteLine($"wynik: {wynik}");
    }

    static void Konwerter()
    {
        Console.WriteLine("ZADANIE 2: konwerter temperatur");
        Console.Write("Wybierz kierunek konwersji (C->F (wybierz C) lub F->C (wybierz F)): ");
        string kierunek = Console.ReadLine().ToUpper();
        Console.Write("podaj temperature: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (kierunek == "C")
        {
            double wynik = temp * 1.8 + 32;
            Console.WriteLine($"{temp}°C = {wynik:F2}°F");
        }
        else if (kierunek == "F")
        {
            double wynik = (temp - 32) / 1.8;
            Console.WriteLine($"{temp}°F = {wynik:F2}°C");
        }
        else
        {
            Console.WriteLine("error");
        }
    }

    static void SredniaOcen()
    {
        Console.WriteLine("ZADANIE 3: srednia ocen");
        Console.Write("ile ocen chcesz podac? ");
        int n = Convert.ToInt32(Console.ReadLine());

        double suma = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"podaj ocenę {i}: ");
            suma += Convert.ToDouble(Console.ReadLine());
        }

        double srednia = suma / n;
        Console.WriteLine($"srednia: {srednia:F2}");

        if (srednia >= 3.0)
            Console.WriteLine("zdal");
        else
            Console.WriteLine("nie zdal");
    }
}
