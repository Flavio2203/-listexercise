// See https://aka.ms/new-console-template for more information
using System;

class lista01
{
    static void Main(string[] args)
    {
        //exercicio 01
        Console.WriteLine("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de C: ");
        int c = int.Parse(Console.ReadLine());

        int soma = a + b;

        if (soma < c)
        {
            Console.WriteLine("A soma de A + B é menor que C.");
        }
        else
        {
            Console.WriteLine("A soma de A + B não é menor que C.");
        }
    }
}

