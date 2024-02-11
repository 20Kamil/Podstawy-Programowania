using System;

namespace Kantor
{
    class Program
    {
        private static void Main()
        {
            const double eur = 1.08, chf = 1.12, gbp = 1.14, usd = 3.99;

            Console.WriteLine("Ile PLN chcesz przewalutować?");
            var pln = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Wybierz walutę: \n1. EUR ({eur})\n2. CHF ({chf})\n3. GBP ({gbp})");
            var choice = Convert.ToInt32(Console.ReadLine());
            pln /= usd;

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Proszę, {pln * eur} EUR.");
                    break;
                case 2:
                    Console.WriteLine($"Proszę, {pln * chf} CHF.");
                    break;
                case 3:
                    Console.WriteLine($"Proszę, {pln * gbp} GBP.");
                    break;
                default:
                    Console.WriteLine("Zły wybór.");
                    break;
            }
        }
    }
}

