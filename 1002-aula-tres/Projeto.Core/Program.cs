// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
List <string> listasDasBandas = new List<string> {"U2", "The beatles", "Mamonas Assassina"};

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
    Console.WriteLine("Digite [4] para exibir a média de uma banda");
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
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhida);
            break;
        case -1: Console.WriteLine("Tchau Tchau :) " + opcaoEscolhida);
            break;
        default: Console.WriteLine("Opção inválida!");
            break;

    }
}

void RegistrarBandas()
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("*******************************************");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listasDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda foi {nomeDaBanda} registrada com sucesso!", nomeDaBanda);
    Thread.Sleep(2000);
    Console.Clear();
    ExibirLogo();
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas(){
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("Exibindo todas as bandas registradas!");
    Console.WriteLine("*******************************************\n");

    // for(int i = 0; i < listasDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {listasDasBandas[i]}");
    // }
    foreach(string banda in listasDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nDigite um dtecla para voltar para o menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

ExibirLogo();
ExibirOpcoesDoMenu();
