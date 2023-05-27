// See https://aka.ms/new-console-template for more information

class Lista07
{
    static void Main(string[] args)
    {
        //Exercicio 07
        Console.WriteLine("Digite um numero");
        int numero = int.Parse(Console.ReadLine());
        int resultado;

        if(numero %2 ==0)
        {
            resultado = numero + 5;
        }
        else
        {
            resultado = numero + 8;
        }
        Console.WriteLine("Resultado e:" + resultado);
    }
}
