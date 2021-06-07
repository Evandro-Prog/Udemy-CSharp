using System;
using System.Globalization;

namespace Exercicio_de_Fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa que lê os seguintes valores:
            //Seu nome completo,
            //quantos quartos tem sua casa,
            //Preço de um produto a sua escolha,
            //Entre com seu ultimo nome, idade e altura na mesma linha.

            string nome = Console.ReadLine();
            int quartos = int.Parse(Console.ReadLine());
            double preco = double.Parse(Console.ReadLine());
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Seu nome completo é " + nome);
            Console.WriteLine("Sua casa tem " + quartos + " quartos");
            Console.WriteLine("O preço do produto escolhido é " + preco);
            Console.WriteLine("Seu último nome é " + sobrenome);
            Console.WriteLine("Sua idade é " + idade);
            Console.WriteLine("Sua altura é " + altura.ToString("F2", CultureInfo.InvariantCulture));
           


        }
    }
}
