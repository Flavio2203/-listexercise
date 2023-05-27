// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;


class lista10
{
    static void Main(string[] args)
    {
        //exercicio 10
        decimal IMC = 0;
        decimal Peso = 0;
        decimal Altura = 0;

        Console.WriteLine("Digite o seu Peso:");
        Peso = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite a sua altura:");
        Altura = decimal.Parse(Console.ReadLine());

        IMC = (Peso / (Altura * Altura));

        Console.WriteLine("O IMC da pessoa é: {0}, o Peso é de: {1}, e a altura é de: {2}", IMC, Peso, Altura);

        if (IMC < 18.5m)
        {
            Console.WriteLine("A pessoa está abaixo do peso");
        }
        else if (IMC >= 18.5m && IMC < 25)
        {
            Console.WriteLine("A pessoa está no peso normal");
        }
        else if (IMC >= 25 && IMC < 30)
        {
            Console.WriteLine("A pessoa está acima do peso");
        }
        else
        {
            Console.WriteLine("A pessoa está obesa");
        }

        Console.ReadLine();
    }
}

