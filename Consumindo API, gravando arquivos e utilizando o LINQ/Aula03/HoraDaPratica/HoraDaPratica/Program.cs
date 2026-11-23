//----------Exercício 1----------
//List<int> numeros = new List<int>
//{
//    1, 2, 3, 2, 4, 5, 1, 6, 3, 7, 8, 8, 9
//};

//var elementosUnicos = numeros.Distinct();

//foreach(var elementos in elementosUnicos) { 
//    Console.WriteLine(elementos);
//}

//----------Exercício 2----------
//using HoraDaPratica.Model;

//List<Livro> livros = new List<Livro>
//{
//    new Livro { Titulo = "O Hobbit", Autor = "J.R.R. Tolkien", AnoPublicacao = 1937 },
//    new Livro { Titulo = "A Menina que Roubava Livros", Autor = "Markus Zusak", AnoPublicacao = 2005 },
//    new Livro { Titulo = "Harry Potter e a Pedra Filosofal", Autor = "J.K. Rowling", AnoPublicacao = 1997 },
//    new Livro { Titulo = "A Culpa é das Estrelas", Autor = "John Green", AnoPublicacao = 2012 },
//    new Livro { Titulo = "O Código Da Vinci", Autor = "Dan Brown", AnoPublicacao = 2003 },
//    new Livro { Titulo = "1984", Autor = "George Orwell", AnoPublicacao = 1949 }
//};

//var livrosPos2000 = livros.Where(livro => livro.AnoPublicacao > 2000).Select(livro => livro.Titulo).OrderBy(titulo => titulo).ToList();

//foreach (var livro in LivrosPos2000)
//{
//    Console.WriteLine(livro);
//}


//----------Exercício 3----------
//using HoraDaPratica.Model;

//List<Produto> produtos = new List<Produto>
//{
//    new Produto { Nome = "Notebook", Preco = 3500.00m },
//    new Produto { Nome = "Mouse", Preco = 80.00m },
//    new Produto { Nome = "Teclado", Preco = 150.00m },
//    new Produto { Nome = "Monitor", Preco = 1200.00m },
//    new Produto { Nome = "Headset", Preco = 270.00m }
//};


//Console.WriteLine($"O preço médio dos produtos é: {produtos.Select(p => p.Preco).Average()}");



//----------Exercício 4----------
List<int> numeros = new List<int>
{
    10, 15, 22, 31, 44, 57, 60, 73, 86, 91, 100
};

var pares = numeros.Where(n => n % 2 == 0);

foreach (int numero in pares)
{
    Console.WriteLine(numero);
}
