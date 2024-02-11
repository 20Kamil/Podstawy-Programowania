using System;

namespace TwierdzeniePitagorasa
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3.5;
            double b = 6;

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            Console.WriteLine($"Trójkąt prostokątny o przyprostokątnych {a} i {b} ma długość przeciwprostokątnej {c}.");
        }
    }
}
    

