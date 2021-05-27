using System;
using System.Globalization;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;

            string nome = "Mikaela"; // usa-se aspas duplas para declara variavel tipo String

            int idade = 30;

            char feminino = 'F'; // usa-se aspas simples para declarar a variavel char

            Console.WriteLine(x);

            Console.WriteLine(x.ToString("F2")); //F + NUMERO define numero de casas decimais que vão aparecer

            Console.WriteLine(x.ToString("F4"));

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); //CultureInfo.InvariantCulture imprime o numero separadopor . no lugar da ,

            //concatena varios elementos em um mesmo comando de escrita (elemento + elemento2 + elemento3......)

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é" + x + "reais.");
            Console.WriteLine("O valor do troco é" + x.ToString("F2") + "reais");

            Console.WriteLine();
            Console.WriteLine("A paciente " + nome + " tem " + idade + " e seu sexo é: " + feminino);

            Console.ReadLine();


        }
    }
}
