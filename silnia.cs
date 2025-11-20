using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę do obliczenia silni:");
        int liczba = Convert.ToInt32(Console.ReadLine());

        int silnia = 1;

        for (int i = 1; i <= liczba; i++)
        {
            silnia = silnia * i;
        }

        Console.WriteLine($"Silnia z {liczba} to: {silnia}");
    }
}