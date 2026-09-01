Using System;

Class Program
{
    Static void Main()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("       CADASTRO DE FILME");
        Console.WriteLine("=================================");

        Console.Write("Nome do filme: ");
        String nome = Console.ReadLine();

        Console.Write("Nome do diretor: ");
        String diretor = Console.ReadLine();

        Console.Write("Ano de lançamento: ");
        int ano = Int.Parse(Console.ReadLine());

        Console.Write("Duração em minutos: ");
        int duracao = Int.Parse(Console.ReadLine());

        Console.Write("Nota do filme: ");
        Double nota = Double.Parse(Console.ReadLine());

        Console.Write("O filme já foi assistido? (true/false): ");
        bool assistido = bool.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("=================================");
        Console.WriteLine("       FILME CADASTRADO");
        Console.WriteLine("=================================");

        Console.WriteLine("Filme: " + nome);
        Console.WriteLine("Diretor: " + diretor);
        Console.WriteLine("Ano de lançamento: " + ano);
        Console.WriteLine("Duração: " + duracao + " minutos");
        Console.WriteLine("Nota: " + nota.ToString("F1"));
        Console.WriteLine("Já foi assistido: " + assistido);

        Console.WriteLine();
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
