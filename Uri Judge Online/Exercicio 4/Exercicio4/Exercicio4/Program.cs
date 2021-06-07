using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {

            int X, Y, PROD;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            PROD = X * Y;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
