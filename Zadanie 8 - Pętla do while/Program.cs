using System;

namespace PetlaDoWhile
{
    class Program
    {
        private static void Main()
        {
            var i = 1;
            do
            {
                var square = i * i;
                Console.WriteLine($"Kwadratem {i} jest {square}");
                i++;
            } while (i <= 20);
        }
    }
}

