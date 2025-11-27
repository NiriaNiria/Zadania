using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        // Losowanie 6 liczb
        int[] wylosowaneLiczby = new int[6];
        for (int i = 0; i < wylosowaneLiczby.Length; i++)
        {
            wylosowaneLiczby[i] = random.Next(1, 50); // 1–49
        }

        Console.WriteLine("Podaj 6 liczb od 1 do 49:");

        int[] liczbyUzytkownika = new int[6];
        for (int i = 0; i < liczbyUzytkownika.Length; i++)
        {
            Console.Write("Liczba " + (i + 1) + ": ");
            liczbyUzytkownika[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Twoje liczby: " + string.Join(", ", liczbyUzytkownika));
        Console.WriteLine("Wylosowane liczby: " + string.Join(", ", wylosowaneLiczby));

        int trafienia = 0;

        foreach (int liczbaUzytk in liczbyUzytkownika)
        {
            foreach (int liczbaLos in wylosowaneLiczby)
            {
                if (liczbaUzytk == liczbaLos)
                {
                    trafienia++;
                    break;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("Trafiłaś: " + trafienia + " liczb.");
    }
}
