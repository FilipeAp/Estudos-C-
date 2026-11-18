using System.Text.Json.Serialization;

namespace HoraDaPratica.Modelo;

internal class Filme
{
    [JsonPropertyName("title")]
    public string Titulo { get; set; }

    [JsonPropertyName("year")]
    public string AnoLancamento { get; set; }

    [JsonPropertyName("crew")]
    public string Elenco {  get; set; }

    [JsonPropertyName("imDbRating")]
    public string Nota { get; set; }

    public void ExibirDetalhesFilme()
    {
        Console.WriteLine($"Título do Filme: {Titulo}\nAno de Lançamento: {AnoLancamento}\nElenco: {Elenco}\nNota no IMDb: {Nota}");
    }
}
