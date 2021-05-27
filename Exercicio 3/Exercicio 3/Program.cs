using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARTE 1

            // int  x, y;

            // x = 5;

            // y = 2 * x; //multiplica o numero pelo valor da varialve x para encontrar a variavel y

            // Console.WriteLine(x);
            // Console.WriteLine(y);

            // Console.ReadLine();

            //PARTE 2

            // int x;
            // double y;

            // x = 5;

            // y = 2 * x;

            // Console.WriteLine(x);
            // Console.WriteLine(y);

            // Console.ReadLine();

            //PARTE 3

            // double b, B, h, area;

            // b = 6.0;
            // B = 8.0;
            // h = 5.0;

            // area = (b + B) / 2.0 * h;

            // Console.WriteLine(area);

            // Console.ReadLine();

            // BOAS PRATICAS : sempre indique o tipo de numero se a ecpressão for de ponto flutuante (numeros com casas decimais).
            // Para Double use .0
            // Para float use f

            //PARTE 4

            // float b, B, h, area;

            // b = 12f;
            // B = 34f;
            // h = 78f;

            // area = (b = B) / 2f * h;

            // Console.WriteLine(area);
            // Console.ReadLine();

            //PARTE 5

            // int a, b;            // Quando a varialvel é definida como um tipo e no caso de uma expressão o resultado deve ser de outro tipo,
            // double resultado;    // devemos fazer um "casting" que nada mais é a consversão explicita de um tipo de variavel para outro.

            // a = 48;
            // b = 10;

            // resultado = (double)  a / b;  //nesse caso colocamos a variavel a quel queremos que seja o resultado entre () antes da expressão

            // Console.WriteLine(resultado);


            //PARTE 6

            double a;
            int b;

            a = 5.0;
            b = (int) a; // Casting para converter a variavel a (double) em um numero inteiro


            Console.WriteLine(b);
            Console.ReadLine();
            


        







        }
    }
}
