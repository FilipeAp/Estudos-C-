namespace HoraDaPratica.Modelo;

internal class Livro
{
    public string titulo { get; set; }
    public string autor { get; set; }
    public int ano_publicacao { get; set; }
    public string genero { get; set; }
    public int paginas { get; set; }
    public string editora { get; set; }
    public void DetalhesLivro()
    {
        Console.WriteLine($"Título: {titulo}\nAutor: {autor}\nAno de Publicação: {ano_publicacao}\nGênero: {genero}\nPáginas: {paginas}\nEditora: {editora}");
    }
}

