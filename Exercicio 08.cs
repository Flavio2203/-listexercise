// See https://aka.ms/new-console-template for more information

using System;

class lista08
{
    static void Main()
    { 
        //Exercicio 8
        int[] numeros = new int[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite o {0}º número inteiro: ", i + 1);
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números em ordem decrescente:");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }
    }
}
