namespace HoraDaPratica.Modelo;

internal class Carro
{
    public string marca { get; set; }
    public string modelo { get; set; }
    public int ano { get; set; }
    public string tipo { get; set; }
    public string motor { get; set; }
    public string transmissao { get; set; }

    public void ApresentarCarro()
    {
        Console.WriteLine($"Marca: {marca}\nModelo: {modelo}\nAno: {ano}\nTipo: {tipo}\nMotor: {motor}\nTransmissão: {transmissao}");
    }
}
