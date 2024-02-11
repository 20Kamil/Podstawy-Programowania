using System;

namespace KalkulatorBMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oblicz swój wskaźnik masy ciała.");
            Console.WriteLine("Podążaj za instrukcjami kalkulatora.");

            Console.WriteLine("Podaj swoją masę ciała [kg]:");
            double wagaKg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj swój wzrost [cm]:");
            double wzrostCm = Convert.ToDouble(Console.ReadLine());

            double wzrostM = wzrostCm / 100;

            double bmi = wagaKg / Math.Pow(wzrostM, 2);

            Console.WriteLine($"Twoje BMI wynosi {bmi}.");
        }
    }
}


