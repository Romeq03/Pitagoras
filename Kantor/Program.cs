using System;

class Program
{
    static void Main()
    {
        // Kursy wymiany walut
        const double KursUSD_PLN = 3.8;
        const double KursUSD_EUR = 0.85;
        const double KursUSD_CHF = 0.92;
        const double KursUSD_GBP = 0.75;

        // Wprowadzenie kwoty w PLN
        Console.Write("Podaj kwotę w PLN: ");
        if (double.TryParse(Console.ReadLine(), out double kwotaPLN))
        {
            // Wybór waluty docelowej
            Console.Write("Podaj walutę docelową (EUR, CHF, GBP): ");
            string walutaDocelowa = Console.ReadLine().ToUpper();

            // Przeliczenie na walutę pośrednią (USD)
            double kwotaUSD = kwotaPLN / KursUSD_PLN;

            // Przeliczenie na walutę docelową
            double wynik = 0;
            switch (walutaDocelowa)
            {
                case "EUR":
                    wynik = kwotaUSD * KursUSD_EUR;
                    break;
                case "CHF":
                    wynik = kwotaUSD * KursUSD_CHF;
                    break;
                case "GBP":
                    wynik = kwotaUSD * KursUSD_GBP;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowa waluta docelowa.");
                    return;
            }

            // Wyświetlenie wyniku
            Console.WriteLine($"Przeliczona kwota: {wynik:F2} {walutaDocelowa}");
        }
        else
        {
            Console.WriteLine("Nieprawidłowa kwota. Spróbuj ponownie.");
        }
    }
}
