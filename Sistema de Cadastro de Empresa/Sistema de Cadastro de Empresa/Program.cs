using System;

class Program
{
    static void Main()
    {
        // Título do sistema
        Console.WriteLine("=================================");
        Console.WriteLine("     CADASTRO DE EMPRESA");
        Console.WriteLine("=================================");

        // Solicitação dos dados da empresa
        Console.Write("Nome da empresa: ");
        string nome = Console.ReadLine();

        Console.Write("CNPJ: ");
        string cnpj = Console.ReadLine();

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Nome do responsável: ");
        string responsavel = Console.ReadLine();

        Console.Write("Número de funcionários: ");
        int funcionarios = int.Parse(Console.ReadLine());

        Console.Write("Faturamento mensal: ");
        double faturamento = double.Parse(Console.ReadLine());

        Console.Write("A empresa está ativa? (true/false): ");
        bool ativa = bool.Parse(Console.ReadLine());

        // Exibição dos dados cadastrados
        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("       EMPRESA CADASTRADA");
        Console.WriteLine("=================================");

        Console.WriteLine("Nome da empresa: " + nome);
        Console.WriteLine("CNPJ: " + cnpj);
        Console.WriteLine("Cidade: " + cidade);
        Console.WriteLine("Responsável: " + responsavel);
        Console.WriteLine("Funcionários: " + funcionarios);
        Console.WriteLine("Faturamento mensal: R$ " + faturamento.ToString("F2"));
        Console.WriteLine("Empresa ativa: " + ativa);

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
