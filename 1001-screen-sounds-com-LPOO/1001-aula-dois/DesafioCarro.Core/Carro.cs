class Carro
{
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public int? Ano { get; set; }

    public Carro(string fabricante, string modelo, int ano)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        Ano = (ano >= 1960 && ano <= 2023) ? ano : null;
    }

    public void Acelerar()
    {
        Console.WriteLine("Acelerando o carro...");
    }

    public void Frear()
    {
        Console.WriteLine("Freando o carro...");
    }

    public void Buzinar()
    {
        Console.WriteLine("Buzinando... BEEP BEEP!");
    }

    public void DescricaoDetalhada()
    {
        Console.WriteLine($"{Fabricante} | {Modelo} | {Ano}");
    }
}
