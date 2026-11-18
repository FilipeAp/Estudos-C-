
using HoraDaPratica;
using HoraDaPratica.Modelo;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        async Task<List<T>> Deserializasao<T>(string endpoint) { 
            
            string resposta = await client.GetStringAsync(endpoint);

            var itens = JsonSerializer.Deserialize<List<T>>(resposta)!;

            return itens;
        }

        //----------Atividade 1----------
        var filmes = await Deserializasao<Filme>("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        filmes[9].ExibirDetalhesFilme();

        //----------Atividade 2----------
        Console.WriteLine("\n\n");
        var paises = await Deserializasao<Pais>("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        paises[3].ApresentarPais();

        //----------Atividade 3----------
        Console.WriteLine("\n\n");
        var carros = await Deserializasao<Carro>("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        carros[2].ApresentarCarro();
        //----------Atividade 4----------
        Console.WriteLine("\n\n");
        var livros = await Deserializasao<Livro>("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        livros[1].DetalhesLivro();


    }
    catch (Exception ex)
    {
        Console.WriteLine("Ocorreu um erro na consulta:\n" + ex.Message);
    }
}

