public class Program
{
    public static double dlugosc(double x1, double x2, double y1, double y2)
    {
        double dx, dy, modul;
        dx = x2 - x1;
        dy = y2 - y1;
        modul = Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        return modul;
    }


    public static void Main(string[] args)
    {
        double x1, x2, y1, y2;
        Console.WriteLine("Program liczy długość odcinka w układzie kartezjańskim");
        Console.WriteLine("\nPodaj współrzędne punktu A(x1,y1)");
        x1 = double.Parse(Console.ReadLine());
        y1 = double.Parse(Console.ReadLine());
        Console.WriteLine("\nPodaj współrzędne punktu B(x2,y2)");
        x2 = double.Parse(Console.ReadLine());
        y2 = double.Parse(Console.ReadLine());

        Console.WriteLine("\nDługość odcinka AB: "+dlugosc(x1, x2, y1, y2));
    }
}