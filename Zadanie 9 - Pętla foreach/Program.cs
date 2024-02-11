using System;

namespace PetlaForeach
{
    class Program
    {
        private static void Main()
        {
            string[] pets = { "kot", "pies", "papuga", "świnka morska" };

            foreach (var pet in pets)
            {
                Console.WriteLine(pet);

                if (pet != "pies") continue;

                Console.WriteLine("Koniec.");
                Console.WriteLine("Chcesz zobaczyć pełną listę? (t/n)");
                var answer = Console.ReadLine()?.ToLower();

                if (answer == "t")
                    continue;
                else if (answer == "n")
                {
                    break;
                }
            }
        }
    }
}

