// Screen Sound
using System.Runtime;
using System.Runtime.CompilerServices;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List <string> bandasRegistradasLista = new List<string> {"Link Park", "Beatles"};

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); 
bandasRegistradas.Add("Link Park", new List<int> {10, 8, 4});
bandasRegistradas.Add("Beatles", new List<int>());

void ExibirLogo(){
    Console.WriteLine(@"

        ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░░██████╗
        ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔════╝
        ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║╚█████╗░
        ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║░╚═══██╗
        ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██████╔╝
        ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═════╝░
    ");
Console.WriteLine(mensagemDeBoasVindas);
};

void ExibirOpcoesDoMenu(){
    Console.WriteLine("\nDigite [1] para registrar uma banda");
    Console.WriteLine("Digite [2] para mostrar todas as bandas");
    Console.WriteLine("Digite [3] para avaliar uma banda");
    Console.WriteLine("Digite [4] para exibir a média de bandas");
    Console.WriteLine("Digite [-1] para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch(opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas();
            break;
        case 2: ExibirBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirNotasDasBandas();
            break;
        case -1: Console.WriteLine("Tchau Tchau :) " + opcaoEscolhida);
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }
}

void ExibirTituloDaOpcao(string titulo){

    int quantidadeDeLetras = titulo.Length;
    string detalhe = string.Concat(Enumerable.Repeat("*",quantidadeDeLetras));
    Console.WriteLine(detalhe);
    Console.WriteLine($"{titulo}");
    Console.WriteLine(detalhe + "\n");
}

void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    // Adicionando na ListaDeBandas tb para ter o indice
    bandasRegistradasLista.Add(nomeDaBanda);
    Console.WriteLine($"A banda foi {nomeDaBanda} registrada com sucesso!", nomeDaBanda);
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas(){
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas!");

    // for(int i = 0; i < bandasRegistradas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {bandasRegistradas[i]}");
    // }
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite um dtecla para voltar para o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void AvaliarUmaBanda()
{
    // Digitar a banda que deseja avaliar
    // Se a banda existir no dicionario >> atribuir nota
    // Se não volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda!");

    Console.Write("{ ");
    for(int i = 0; i < bandasRegistradasLista.Count; i++)
    {
        Console.Write($"[{i}]{bandasRegistradasLista[i]}, ");
    }
    Console.Write(" }");
    Console.Write($"\nQual banda deseja avaliar [?]: ");

    int opcaoBanda = int.Parse(Console.ReadLine());
    string opcaoBandaTexto = bandasRegistradasLista[opcaoBanda];
    if(bandasRegistradas.ContainsKey(opcaoBandaTexto))
    {
        Console.WriteLine($"Qual nota deseja dar para a banda {opcaoBandaTexto} de 0 a 10: ");
        int notaDaBanda = int.Parse(Console.ReadLine());

        if(notaDaBanda > 0 && notaDaBanda <= 10)
        {
            Console.WriteLine("Nota Adicionada com sucesso!");
            bandasRegistradas[opcaoBandaTexto].Add(notaDaBanda);
            
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesDoMenu();
        }
        else 
        {
            Console.WriteLine("Nota inválida, digite uma nota de 0 a 10!");
            Thread.Sleep(1000);
            AvaliarUmaBanda();
        }
    }
    else
    {
        Console.WriteLine("Nome da banda não exite, por favor digite uma banda que exista na lista acima!");
        Console.WriteLine($"Encaminhanda para Menu de opções...");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}

void ExibirNotasDasBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Notas das Bandas!");

    foreach (var banda in bandasRegistradas)
    {
        string nome = banda.Key;
        List<int> notas = banda.Value;

        if (notas.Count > 0)
        {
            double media = notas.Average();
            Console.WriteLine($"Banda: {nome}\nMédia das notas: {media:F2}");
        }
        else
        {
            Console.WriteLine($"Banda: {nome}\nSem avaliações.");
        }
        Console.WriteLine("--------------------");
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

ExibirLogo();
ExibirOpcoesDoMenu();
