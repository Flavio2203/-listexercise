// See https://aka.ms/new-console-template for more information


class lista03
{

    static void Main(string[] args)
    {
        // Exercicio 03
        Console.WriteLine("digite um numero");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("E par.");
        }

        else
        {
            Console.WriteLine("O numero e impar.");
        }

    }
}