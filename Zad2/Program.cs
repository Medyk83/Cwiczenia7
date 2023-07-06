// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj współrzędne punktu początkowego (x1, y1):");
        double x1 = WczytajLiczbeRzeczywista("x1");
        double y1 = WczytajLiczbeRzeczywista("y1");

        Console.WriteLine("Podaj współrzędne punktu końcowego (x2, y2):");
        double x2 = WczytajLiczbeRzeczywista("x2");
        double y2 = WczytajLiczbeRzeczywista("y2");

        double dlugoscOdcinka = ObliczDlugoscOdcinka(x1, y1, x2, y2);

        Console.WriteLine($"Długość odcinka wynosi: {dlugoscOdcinka}");
        Console.ReadLine();
    }

    static double WczytajLiczbeRzeczywista(string nazwa)
    {
        double liczba;
        bool poprawnaWartosc;

        do
        {
            Console.Write($"Podaj wartość dla {nazwa}: ");
            poprawnaWartosc = double.TryParse(Console.ReadLine(), out liczba);

            if (!poprawnaWartosc)
            {
                Console.WriteLine("Niepoprawna wartość. Podaj poprawną liczbę rzeczywistą.");
            }

        } while (!poprawnaWartosc);

        return liczba;
    }

    static double ObliczDlugoscOdcinka(double x1, double y1, double x2, double y2)
    {
        double dlugosc = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return dlugosc;
    }
}
