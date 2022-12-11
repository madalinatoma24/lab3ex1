using System;

namespace lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 1  Scrieti o functie care va calcula suma cifrelor unui numar.
             */
            Console.WriteLine("Introduceti numarul: ");
            int numar = int.Parse(Console.ReadLine());
            int suma = SumaCifrelor(numar);
            Console.WriteLine($"Suma cifrelor numarului {numar} este: {suma}");

            static int SumaCifrelor(int n) {
                var sum = 0;
                while (n > 0)
                {
                    sum = sum + (n % 10);
                    n = n / 10;
                }
                return sum;
            }
        }
    }
}
