Musica musica = new Musica();
musica.Nome = "seu sorriso";
musica.Artist = "raça";
musica.Duracao = 273;
System.Console.WriteLine(musica.Disponivel);
musica.Disponivel = false;
musica.ExibirFichaTecnica();
Console.WriteLine($"\n{musica.DescricaoResumida}");

// Musica musica1 = new Musica();
// musica1.nome = "meu cabeleleiro";
// musica1.artist = "betocarreiro";
// musica1.duracao = 300;
// musica1.GetDisponivel();
// musica1.SetDisponivel(true);
// musica1.ExibirFichaTecnica();