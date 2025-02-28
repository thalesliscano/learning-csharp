class Musica
{
    public string? Nome { get; set; }
    public string? Artist { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; } 

    // atributos são quando não tem get e nem set, quando tem eles são propriedades e precisam seguir o pascalCase
    // function lambda
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artist}";
    public string DescricaoResumidaDois
    {
         get
         {
            return $"A música {Nome} pertence à banda {Artist}";
         } 
    }
    public void ExibirFichaTecnica()
    {
        System.Console.WriteLine($"Nome: {Nome}");
        System.Console.WriteLine($"Artista: {Artist}");
        System.Console.WriteLine($"Duração: {Duracao}");
        if(Disponivel)
        {
        System.Console.WriteLine($"Disponivel no plano");
        }
        else
        {
            System.Console.WriteLine($"A música não esta disponível");
        }
    }

}