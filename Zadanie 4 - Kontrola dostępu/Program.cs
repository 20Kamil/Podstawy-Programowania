using System;

namespace KontrolaDostepu
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Wpisz swój wiek:");
            var age = Convert.ToInt32(Console.ReadLine());

            switch (age)
            {
                case >= 18:
                    Console.WriteLine("Dostęp przyznany.");
                    break;
                case >= 15:
                {
                    Console.WriteLine("Czy masz zgodę rodzica? (t/n)");
                    var answer = Console.ReadLine();

                    switch (answer?.ToLower())
                    {
                        case "t":
                            Console.WriteLine("Dostęp przyznany.");
                            break;
                        case "n":
                            Console.WriteLine("Odmowa dostępu.");
                            break;
                        default:
                            Console.WriteLine("Zła odpowiedź.");
                            break;
                    }

                    break;
                }
                default:
                    Console.WriteLine("Odmowa dostępu.");
                    break;
            }
        }
    }
}

