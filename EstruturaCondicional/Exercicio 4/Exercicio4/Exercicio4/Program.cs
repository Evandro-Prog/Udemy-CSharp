using System;
using System.Globalization;

namespace Exercicio4
{
    class Program

        //Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara.
        //Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”,
        //caso haja uma divisão por 0 ou raiz de numero negativo.
        //Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto,
        //com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.

    {
        static void Main(string[] args)
        {

            double a, b, c, delta, r1, r2;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0 || delta < 0.0)
            {

                Console.WriteLine("Impossivel Calcular");

            }
            else
            {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
