using ByteBankIO;
using System.Text;
using System.Xml;
namespace ByteBankIO;

partial class Program
{
    //Quando compilarmos e executarmos a aplicação, o programa entenderá que a classe Program está em vários arquivos e pode ser trabalhada de uma forma única. Ela está separada apenas por questões de organização.
    static void Main(string[] args)
    {
        //var enderecoDoArquivo = "contas.txt";

        //using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        //{
        //    var leitor = new StreamReader(fluxoDeArquivo);

        //    //var linha = leitor.ReadLine(); //como o nome sugere, lerá uma linha do arquivo. Como não especificamos, o leitor.ReadLine selecionará a primeira linha no nosso arquivo e armazenará essa string na variável linha
        //    //var texto = leitor.ReadToEnd(); //Com o método ReadToEnd, conseguimos fazer a leitura do arquivo sem precisar lidar com buffer e decodificação de bytes.
        //    //var numero = leitor.Read(); //traz o primeiro caractere em byte

        //    while(!leitor.EndOfStream)
        //    {//end of stream significa "fim do fluxo", enquanto não chegarmos ao final do fluxo, vamos ler uma linha e a exibir ao usuário. Aqui os dados não são decodificados de uma vez como no readToEnd. Aqui eles são lidos por partes.
        //        var linha = leitor.ReadLine();
        //        var contaCorrente = ConverterStringParaContaCorrente(linha);

        //        var msg = $"{contaCorrente.Titular.Nome} : Conta número {contaCorrente.Numero}, ag {contaCorrente.Agencia}, saldo {contaCorrente.Saldo}";
        //        Console.WriteLine(msg);
        //    }
        //}

        //Console.ReadLine();
        //CriarArquivo();
        CriarArquivoComWriter();

    }

    //static ContaCorrente ConverterStringParaContaCorrente(string linha)
    //{
    //    var campos = linha.Split(',');

    //    var agencia = campos[0];
    //    var numero = campos[1];
    //    var saldo = campos[2].Replace('.', ',');
    //    var nomeTitular = campos[3];


    //    var agenciaComInt = int.Parse(agencia);
    //    var numeroComInt = int.Parse(numero);
    //    var saldoComDouble = double.Parse(saldo);

    //    var titular = new Cliente();
    //    titular.Nome = nomeTitular;

    //    var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
    //    resultado.Depositar(saldoComDouble);
    //    resultado.Titular = titular;

    //    return resultado;
    //}


}