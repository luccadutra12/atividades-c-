using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("         CADASTRO DE JOGO");
        Console.WriteLine("=================================");

        Console.Write("Nome do jogo: ");
        string nome = Console.ReadLine();

        Console.Write("Plataforma: ");
        string plataforma = Console.ReadLine();

        Console.Write("Ano de lançamento: ");
        int ano = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade de jogadores: ");
        int jogadores = int.Parse(Console.ReadLine());

        Console.Write("O jogo está instalado? (true/false): ");
        bool instalado = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("         JOGO CADASTRADO");
        Console.WriteLine("=================================");

        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Plataforma: " + plataforma);
        Console.WriteLine("Ano de lançamento: " + ano);
        Console.WriteLine("Preço: R$ " + preco.ToString("F2"));
        Console.WriteLine("Jogadores: " + jogadores);
        Console.WriteLine("Instalado: " + instalado);

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
