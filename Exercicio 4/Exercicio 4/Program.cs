using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PARTE 1
            string frase = Console.ReadLine(); //Comando "Console.ReadLine" lê os dados de entrada passados pelo usuario ou outra fonte
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string s = Console.ReadLine(); // cria a variavel "s" para ser usada como vetor das demais variaveis que serão digitadas na mesma linha,
                                           // porem exibitas em linhas diferentes.

            string[] v = s.Split(' '); //cria um vetor para armazenar cada string digitada em uma variavel diferente
            string a = v[0]; // vetor onde variavel "a" será armazenada
            string b = v[1]; // vetor onde a vaiavel "b" será armazenada
            string c = v[2]; // vetor onde a variavel "c" será armazenada

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            */

            string frase = Console.ReadLine(); //Comando "Console.ReadLine" lê os dados de entrada passados pelo usuario ou outra fonte
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' '); //Forma alternativa para criar um vetor economizando linhas de código
            string a = v[0]; // vetor onde variavel "a" será armazenada
            string b = v[1]; // vetor onde a vaiavel "b" será armazenada
            string c = v[2]; // vetor onde a variavel "c" será armazenada

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}

