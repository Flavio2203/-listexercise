// See https://aka.ms/new-console-template for more information

using System;

class Lista1
{
    static void Main(string[] args)
    {
        //Exercicio 06
        Console.WriteLine("Digite o primeiro valor ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor");
        int valor2 = int.Parse(Console.ReadLine());

        if (valor1 == valor2)
        {
            Console.WriteLine("Os valores são VERDADEIROS.");
        }
        else
        {
            Console.WriteLine("Um dos valores é FALSO.");
        }
    }
}

