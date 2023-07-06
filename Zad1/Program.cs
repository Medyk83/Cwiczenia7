// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Podaj czas w sekundach:");
        int czaswsekundach;

        while (!int.TryParse(Console.ReadLine(), out czaswsekundach) || czaswsekundach <= 0)
        {
            Console.WriteLine("Niepoprawna wartość. Podaj poprawną wartość czasu:");
        }
        int czas = czaswsekundach;
        string sformatowanyCzas = FormatujCzas(czas);
        Console.WriteLine("Sformatowany Czas to: " + sformatowanyCzas);
        Console.ReadLine();
    }

    static string FormatujCzas(int czas)
    {
        int godziny = czas / 3600;
        int minuty = (czas % 3600) / 60;
        int sekundy = (czas % 3600) % 60;

        string sGodziny = godziny.ToString("D2");
        string sMinuty = minuty.ToString("D2");
        string sSekundy = sekundy.ToString("D2");

        string sformatowanyCzas = $"{sGodziny}:{sMinuty}:{sSekundy}";

        return sformatowanyCzas;
    }
}
