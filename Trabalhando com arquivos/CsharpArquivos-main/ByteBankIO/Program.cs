using ByteBankIO;

class Program
{
    static void Main(string[] args)
    {
        var enderecoDoArquivo = "contas.txt";
        var numeroDeBytesLidos = -1;
        
        var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open); //Variável para guardar o fluxo de dados para que possamos percorrer os bytes que contêm os dados desse documento. O FileStream é uma ferramenta importante para lidar com arquivos. Stream significa "fluxo" em inglês, logo, o FileStream trabalhará com o fluxo de dados de um arquivo. Como parametro passamos o endereço do arquivo e o que faremos como ele, nesse caso abriremos.

        var buffer = new byte[1024]; //1Kb - Buffer trata-se de um array que reutilizamos para guardar informações temporárias.

        
        while(numeroDeBytesLidos != 0)
        {
            //retorna o numero de bites lidos. 1° argumento: byte[] array, onde serão armazenados os bytes lidos pelo método, remomamos aqui a ideia de trabalhar com pequenas partes de um documento. 2° argumento: int offset, que delimita o índice em que o método começará a preencher o array. 3° argumento: int count, que informa quantas posições preencher.
            EscreverBuffer(buffer);
        }



        
            
        Console.ReadLine();
    }

    static void EscreverBuffer(byte[] buffer)
    {
        foreach (var meuByte in buffer)
        {
            Console.Write(meuByte);
            Console.Write(" ");
        }
    }
}