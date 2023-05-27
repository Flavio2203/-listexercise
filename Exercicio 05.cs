// See https://aka.ms/new-console-template for more information
class Lista05
{
    static void Main(string[] args)
    {
        //Exercicio 05
        int numero, resultado;

        Console.WriteLine("Digite um número: ");
        numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            resultado = numero * 3;
        }
        else
        {
            resultado = numero * 2;
        }

        Console.WriteLine("O resultado é: " + resultado);
    }
}







