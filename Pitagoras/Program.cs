using System.Security.Cryptography.X509Certificates;

class Program
{
    //zad1
    public static double Pitagoras(double a, double b)
    {
        double przeciwprostokatna = a * a + b * b;
        return przeciwprostokatna;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Math.Sqrt(Pitagoras(3.5, 6)));
    }
}