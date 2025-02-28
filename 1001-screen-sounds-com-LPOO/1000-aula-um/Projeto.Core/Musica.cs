class Musica
{
    public string nome;
    public string artist;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        System.Console.WriteLine($"Nome: {nome}");
        System.Console.WriteLine($"Artista: {artist}");
        System.Console.WriteLine($"Duração: {duracao}");
        if(disponivel)
        {
        System.Console.WriteLine($"Disponivel no plano");
        }
        else
        {
            System.Console.WriteLine($"A música não esta disponível");
        }
    }
}