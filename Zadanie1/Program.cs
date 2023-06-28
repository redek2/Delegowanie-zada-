using System;

public class Program
{
    public static string Czas(int czas)
    {
        int godziny = czas / 3600;
        int minuty = (czas % 3600) / 60;
        int sekundy = czas % 60;

        string sGodziny = godziny.ToString("D2");
        string sMinuty = minuty.ToString("D2");
        string sSekundy = sekundy.ToString("D2");

        return $"{sGodziny}:{sMinuty}:{sSekundy}";
    }

    public static void Main()
    {
        Console.WriteLine("Podaj czas w sekundach:");
        int czas = int.Parse(Console.ReadLine());
        string sformatowanyCzas = Czas(czas);
        Console.WriteLine(sformatowanyCzas);
    }
}
