using System;

namespace Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números primos menores a 1000");
            Console.WriteLine(Sieve.FindPrimes(1000));
        }
    }
}
