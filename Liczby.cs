using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int wylosowanaLiczba = random.Next(1, 101); // 1–100
        int liczbaProb = 0;

        Console.WriteLine("Zgadnij liczbę od 1 do 100:");

        int liczbaUzytkownika = Convert.ToInt32(Console.ReadLine());
        liczbaProb++;

        while (liczbaUzytkownika != wylosowanaLiczba)
        {
            if (liczbaUzytkownika < wylosowanaLiczba)
            {
                Console.WriteLine("Twoja liczba jest za mała.");
            }
            else
            {
                Console.WriteLine("Twoja liczba jest za duża.");
            }

            liczbaUzytkownika = Convert.ToInt32(Console.ReadLine());
            liczbaProb++;
        }

        Console.WriteLine("Gratulacje! Zgadłaś liczbę!");
        Console.WriteLine("Liczba prób: " + liczbaProb);
    }
}
