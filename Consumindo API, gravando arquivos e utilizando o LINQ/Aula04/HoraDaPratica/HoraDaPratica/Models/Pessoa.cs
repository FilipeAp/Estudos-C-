using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HoraDaPratica.Models;

internal class Pessoa
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; }
    [JsonPropertyName("idade")]
    public int Idade { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }

    public void GerarJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            idade = Idade,
            email = Email
        });

        string nomeDoArquivo = $"Informacoes-de-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);

        Console.WriteLine($"A informações foram salvas. Caminho: {Path.GetFullPath(nomeDoArquivo)}");
    }

    public void ExibirDetalhesDaPessoa()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"E-mail: {Email}");

    }
}
