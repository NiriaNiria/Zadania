using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Wpisz swój tekst:");
        string tekst = Console.ReadLine();

        char[] litery = tekst.ToCharArray();
        Array.Reverse(litery);

        string odwroconyTekst = new string(litery);

        Console.WriteLine("Odwrócony tekst:");
        Console.WriteLine(odwroconyTekst);
    }
}
