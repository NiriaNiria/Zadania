using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wpisz swoją liczbę:");
        int liczba = Convert.ToInt32(Console.ReadLine());

        if (liczba % 2 == 0)
        {
            Console.WriteLine("Twoja liczba jest parzysta!");
        }
        else
        {
            Console.WriteLine("Twoja liczba nie jest parzysta!");
        }
    }
}
