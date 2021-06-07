using System;
using System.Globalization;

//Escrever um programa para ler as duas notas que o aluno obteve no primeiro e segundo semestres de uma disciplina anual.
//Em seguida, mostrar a media final que o aluno obteve no ano. Caso a nota final seja maior ou igua a 60.00, exibir a mensagem "APROVADO",
//caso seja inferior exibir a mensagem "REPROVADO". Todos os valores devem ter casa decimais.

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            double notaS1, notaS2, notaFinal;

            notaS1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            notaS2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notaFinal = notaS1 + notaS2 / 2;

            Console.WriteLine("Sua nota final é: " + notaFinal.ToString("F2", CultureInfo.InvariantCulture));

            if (notaFinal >= 60.00)
            {
                Console.WriteLine("ALUNO APROVADO");
            }else
            {
                Console.WriteLine("ALUNO REPROVADO");
            }
        }
    }
}
