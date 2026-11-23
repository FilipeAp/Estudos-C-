using HoraDaPratica.Models;
using System.Text.Json;
//----------Exercício 3----------
List<Pessoa> pessoas = new List<Pessoa>();

var continuar = true;

while (continuar)
{
    Console.Clear();
    Pessoa pessoa = new Pessoa();
    Console.WriteLine("Insira o nome da pessoa:");
    pessoa.Nome = Console.ReadLine();

    Console.WriteLine("Insira a idade da pessoa:");
    pessoa.Idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Insira o E-mail da pessoa:");
    pessoa.Email = Console.ReadLine();

    pessoas.Add(pessoa);
    Console.Clear();
    Console.WriteLine("Deseja registrar outra pessoa? Digite 1 pra Sim ou 2 pra Não");
    int continuarNumero = int.Parse(Console.ReadLine());
    if (continuarNumero == 1)
    {
        continuar = true;
    }
    else if (continuarNumero == 2) { continuar = false; }
    else { 
        Console.WriteLine("Opção inexistente."); 
        continuar = false; 
    }
}

string json = JsonSerializer.Serialize(pessoas);

string nomeDoArquivo = $"Informacoes-de-Pessoas.json";

File.WriteAllText(nomeDoArquivo, json);

Console.WriteLine($"A informações foram salvas. Caminho: {Path.GetFullPath(nomeDoArquivo)}");


//----------Exercício 2----------
//try
//{
//    string fileName = "Informacoes-de-Pedro.json";

//    string jsonString = File.ReadAllText(fileName);

//    var pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString)!;

//    pessoa.ExibirDetalhesDaPessoa();
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//----------Exercício 1----------
//Console.WriteLine("Qual nome da pessoa?");
//Pessoa pessoa = new Pessoa();
//pessoa.Nome = Console.ReadLine();

//Console.WriteLine($"Qual é a idade do(a) {pessoa.Nome}?");
//pessoa.Idade = int.Parse(Console.ReadLine());

//Console.WriteLine($"Qual é o e-mail do(a) {pessoa.Nome}?");
//pessoa.Email = Console.ReadLine();

//pessoa.GerarJson();