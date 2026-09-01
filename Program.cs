using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("       CADASTRO DE PRODUTO");
        Console.WriteLine("=================================");

        Console.Write("Nome do produto: ");
        string nome = Console.ReadLine();

        Console.Write("Código do produto: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        string categoria = Console.ReadLine();

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade em estoque: ");
        int quantidade = int.Parse(Console.ReadLine());

        Console.Write("O produto está disponível? (true/false): ");
        bool disponivel = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("       PRODUTO CADASTRADO");
        Console.WriteLine("=================================");

        Console.WriteLine("Produto: " + nome);
        Console.WriteLine("Código: " + codigo);
        Console.WriteLine("Categoria: " + categoria);
        Console.WriteLine("Preço: " + preco.ToString("F2"));
        Console.WriteLine("Quantidade: " + quantidade);
        Console.WriteLine("Disponível: " + disponivel);

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
