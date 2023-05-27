// See https://aka.ms/new-console-template for more information
using System;

class ABC
{
    static void Main(string[] args)
    {
        //Exercicio 04
        int A, B, C;

        Console.WriteLine("Digite o valor de A: ");
        A = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B: ");
        B = int.Parse(Console.ReadLine());

        if (A != B)
        {
            C = A * B;
        }
        else
        {
            C = A + B;
        }

        Console.WriteLine("O valor de C é: " + C);
    }
}
