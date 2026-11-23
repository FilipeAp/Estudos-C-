using HoraDaPratica.Models;
using System.Text.Json;
//----------Exercício 2----------

try
{
    string fileName = "Informacoes-de-Pedro.json";

    string jsonString = File.ReadAllText(fileName);

    var pessoa = JsonSerializer.Deserialize<Pessoa>(jsonString)!;

    pessoa.ExibirDetalhesDaPessoa();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}






//----------Exercício 1----------
//Console.WriteLine("Qual nome da pessoa?");
//Pessoa pessoa = new Pessoa();
//pessoa.Nome = Console.ReadLine();

//Console.WriteLine($"Qual é a idade do(a) {pessoa.Nome}?");
//pessoa.Idade = int.Parse(Console.ReadLine());

//Console.WriteLine($"Qual é o e-mail do(a) {pessoa.Nome}?");
//pessoa.Email = Console.ReadLine();

//pessoa.GerarJson();