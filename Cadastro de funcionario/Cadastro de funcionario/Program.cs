using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("     CADASTRO DE FUNCIONÁRIO");
        Console.WriteLine("=================================");

        Console.Write("Nome: ");
        string nome = Console.ReadLine();

        Console.Write("Cargo: ");
        string cargo = Console.ReadLine();

        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.Write("Salário: ");
        double salario = double.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("O funcionário está ativo? (true/false): ");
        bool ativo = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("       FICHA DO FUNCIONÁRIO");
        Console.WriteLine("=================================");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Idade: " + idade + " anos");
        Console.WriteLine("Salário: R$ " + salario.ToString("F2"));
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Funcionário ativo: " + ativo);

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
