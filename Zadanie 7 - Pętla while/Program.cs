using System;

namespace PetlaWhile
{
    class Program
    {
        private static void Main()
        {
            var sum = 0;
            var min = int.MaxValue;

            while (true)
            {
                Console.Write("Wpisz liczbę (0-10): ");
                var num = Convert.ToInt32(Console.ReadLine());

                if (num is < 0 or > 10)
                {
                    continue;
                }

                if (num == 5)
                {
                    break;
                }

                if (num < min)
                {
                    min = num;
                }

                sum += num * num;
            }

            Console.WriteLine($"Suma kwadratów: {sum}");
            Console.WriteLine($"Minimalna liczba: {min}");
        }
    }
}


