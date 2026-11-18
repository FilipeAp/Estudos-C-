using System.Text.Json.Serialization;

namespace HoraDaPratica.Modelo;

internal class Pais
{
    public string nome { get; set; }
    public string capital { get; set; }
    public int populacao { get; set; }
    public string continente { get; set; }
    public string idioma { get; set; }

    public void ApresentarPais()
    {
        Console.WriteLine($"Nome: {nome}\nCapital: {capital}\nPopulação: {populacao}\nContinente: {continente}\nIdioma: {idioma}");
    }
}
