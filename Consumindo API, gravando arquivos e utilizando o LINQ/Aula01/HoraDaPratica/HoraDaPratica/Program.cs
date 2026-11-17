//-------------Exercício 4-------------

using HoraDaPratica;

ClasseSimples objetoNulo = null;

try
{
    objetoNulo.UmMetodo();
}
catch (Exception ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}


//-------------Exercício 3-------------
//List<int> inteiros = new List<int> { 123, 456, 789, 1011, 1213, 1415, 1617 };

//while (true) {

//    Console.WriteLine("Digite o Índice de 0 a 6 para acessar um valor, ou -1 para sair:");

//    try
//    {
//        int indice = int.Parse(Console.ReadLine());
//        Console.Clear();
//        if (indice == -1)
//        {
//            return;
//        }
//        Console.WriteLine($"O número no Índice {indice} é o {inteiros[indice]}");
//        Console.WriteLine("Precione qualquer tecla para continuar");
//        Console.ReadKey();
//        Console.Clear();
//    }
//    catch (Exception ex) {
//        Console.Clear();
//        Console.WriteLine($"Ocorreu um erro durante a pesquisa:\n {ex.Message}");
//        Console.WriteLine("Precione qualquer tecla para continuar");
//        Console.ReadKey();
//        Console.Clear();
//    }
//}

//-------------Exercício 2-------------
//Console.WriteLine("Escreva o primeiro número para fazer a divisão");
//int a = int.Parse(Console.ReadLine());

//Console.WriteLine("Escreva o segundo número para fazer a divisão");
//int b = int.Parse(Console.ReadLine());


//try
//{
//    var c = a / b;
//    Console.WriteLine(c);
//}
//catch
//{
//    Console.WriteLine("Não foi possível realizar a conta.");
//}

//-------------Exercício 1-------------
//using (HttpClient client = new HttpClient())
//{
//    try
//    {
//        client.DefaultRequestHeaders.UserAgent.ParseAdd(
//            "MinhaAplicacao/1.0 (meuemail@email.com)"
//        );

//        string resultado = await client.GetStringAsync(
//            "https://www.cheapshark.com/api/1.0/deals"
//        );

//        Console.WriteLine(resultado);
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}