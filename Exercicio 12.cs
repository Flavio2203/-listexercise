// See https://aka.ms/new-console-template for more information


class Lista12
{
    static void Main(string[] args)
    {
        //Exercicio 12
        Console.WriteLine("Informe o número de identificação do aluno:");
        int numeroAluno = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe as 3 notas obtidas pelo aluno:");
        decimal n1 = decimal.Parse(Console.ReadLine());
        decimal n2 = decimal.Parse(Console.ReadLine());
        decimal n3 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Informe a média dos exercícios:");
        decimal mediaExercicios = decimal.Parse(Console.ReadLine());

        decimal mediaAproveitamento = (n1 + n2 * 2 + n3 * 3 + mediaExercicios) / 7;

        Console.WriteLine("Número do aluno: " + numeroAluno);
        Console.WriteLine("Notas: " + n1 + ", " + n2 + ", " + n3);
        Console.WriteLine("Média dos exercícios: " + mediaExercicios);
        Console.WriteLine("Média de aproveitamento: " + mediaAproveitamento);

        if (mediaAproveitamento >= 90)
        {
            Console.WriteLine("Conceito: A");
            Console.WriteLine("Aprovado");
        }
        else if (mediaAproveitamento >= 75)
        {
            Console.WriteLine("Conceito: B");
            Console.WriteLine("Aprovado");
        }
        else if (mediaAproveitamento >= 60)
        {
            Console.WriteLine("Conceito: C");
            Console.WriteLine("Aprovado");
        }
        else if (mediaAproveitamento >= 40)
        {
            Console.WriteLine("Conceito: D");
            Console.WriteLine("Reprovado");
        }
        else
        {
            Console.WriteLine("Conceito: E");
            Console.WriteLine("Reprovado");
        }
    }
}

