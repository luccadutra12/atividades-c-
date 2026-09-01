//SISTEMA DE CADASTRO SIMPLES

using System;
//Metodo Principal de Variáveis
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("================================");
        Console.WriteLine("SISTEMA DE CADASTRO SIMPLES");
        Console.WriteLine("================================");
        Console.WriteLine();

        //Declaração de Variáveis
        string nome;
        int idade;
        double altura;
        string cidade;
        bool estudante;

        //Entrada do nome
        Console.Write("Digite seu nome: ");
        nome = Console.ReadLine();

        //Entrada da idade
        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        //Entrada da altura
        Console.Write("Digite sua altura: ");
        altura = double.Parse(Console.ReadLine());

        //Entrada da cidade
        Console.Write("Digite sua cidade: ");
        cidade = Console.ReadLine();

        //Entrada se é estudante
        Console.Write("Você é estudante? (true/false): ");
        estudante = bool.Parse(Console.ReadLine());

        //Apresentação dos dados cadastrados
        Console.WriteLine("");
        Console.WriteLine("================================");
        Console.WriteLine("DADOS CADASTRADOS");
        Console.WriteLine("================================");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Altura: {altura}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Estudante: {estudante}");

        Console.WriteLine();
        Console.WriteLine("Cadastro realizado com sucesso!");

        //Finalização do programa
        Console.ReadKey();


    }
}