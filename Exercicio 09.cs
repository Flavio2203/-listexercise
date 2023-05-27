// See https://aka.ms/new-console-template for more information


class Lista09
{
    static void Main(string[] args)
    { 
        //Exercico 09
        Console.Write("Digite sua altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite seu sexo (homem ou mulher): ");
        string sexo = Console.ReadLine();

        double pesoIdeal;

        if (sexo == "homem")
        {
            pesoIdeal = (72.7 * altura) - 58;
        }
        else if (sexo == "mulher")
        {
            pesoIdeal = (62.1 * altura) - 44.7;
        }
        else
        {
            Console.WriteLine("Sexo inválido. Por favor, informe 'homem' ou 'mulher'.");
            return;
        }

        Console.WriteLine("Seu peso ideal é: " + pesoIdeal.ToString("0.00") + " kg.");
    }
}
