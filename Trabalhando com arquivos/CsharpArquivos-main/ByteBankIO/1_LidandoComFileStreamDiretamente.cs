using ByteBankIO;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            //Variável para guardar o fluxo de dados para que possamos percorrer os bytes que contêm os dados desse documento. O FileStream é uma ferramenta importante para lidar com arquivos. Stream significa "fluxo" em inglês, logo, o FileStream trabalhará com o fluxo de dados de um arquivo. Como parametro passamos o endereço do arquivo e o que faremos como ele, nesse caso abriremos. O método using criará um try/catch para verificar se o fluxo é nulo. Caso não seja, chamaremos o método Dispose, que internamente chamará o método Close (tratamos assim exeções). 
            var numeroDeBytesLidos = -1;



            var buffer = new byte[1024]; //1Kb - Buffer trata-se de um array que reutilizamos para guardar informações temporárias.


            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024); //retorna o numero de bites lidos. 1° argumento: byte[] array, onde serão armazenados os bytes lidos pelo método, remomamos aqui a ideia de trabalhar com pequenas partes de um documento. 2° argumento: int offset, que delimita o índice em que o método começará a preencher o array. 3° argumento: int count, que informa quantas posições preencher.
                Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            fluxoDoArquivo.Close(); //Após exibir o buffer ao usuário, informaremos ao sistema operacional que o arquivo pode ser fechado, pois já realizamos o que queríamos.



            Console.ReadLine();
        }
    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {
        var utf8 = new UTF8Encoding(); //classe abstrata do tipo Encoding que existe no .NET para fazermos essa decodificação. 

        var texto = utf8.GetString(buffer, 0, bytesLidos); //O método GetString retorna uma string a partir do UTF, fazendo a conversão. 
        //Nessa sobrecarga do método GetString, além do buffer, conseguimos passar informações do índice em que a decodificação deve ser iniciada e a quantidade de bytes que devem ser lidos e exibidos.


        Console.Write(texto);



        /*
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
        */
    }
}