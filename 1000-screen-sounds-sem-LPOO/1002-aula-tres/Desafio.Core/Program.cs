// Desafio Aula
/*
Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, no console.
Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
*/
using System.Reflection;

float a, b;

a = float.Parse(Console.ReadLine());
b = float.Parse(Console.ReadLine());

void OperacoesMatematicas(float a, float b)
{
    float soma = a + b;
    float subtracao = a - b;
    float divisao = a / b;
    float multiplicacao = a * b;

    Console.WriteLine($"Soma: {soma}\nSubtracão: {subtracao}\nDivisão: {divisao}\nMultiplicação: {multiplicacao}");
}

OperacoesMatematicas(a, b);
Thread.Sleep(2000);
// Lista de banda

List<string> listaDeBanda = new List<string>();
Console.Clear();

void ExibirOpcoes()
{
    Console.WriteLine($"Escolha uma opção:\n");
    Console.WriteLine($"1: Adicionar banda\n");
    Console.WriteLine($"2: Ver lista de banda\n");
    Console.WriteLine($"3: Remover uma banda da lista\n");
    Console.WriteLine($"4: Sair\n");

    string escolha = Console.ReadLine();
    int escolhaInt = int.Parse(escolha);

    switch (escolhaInt)
    {
        case 1: AdicionarUmaBanda();
        break;

        case 2: VerLista();
        break;

        case 3: RemoverUmaBanda();
        break;
        case 4: Console.WriteLine($"Tchau Tchau");
        break;
        
        default: Console.WriteLine($"Opção errada, tente novamente");
        break;
        
    }

}

void AdicionarUmaBanda()
{
    Console.Clear();
    Console.Write($"Qual nome da banda: ");
    string nomeDaBanda = Console.ReadLine();
    listaDeBanda.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi adicionar com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoes();
}
void VerLista()
{
    Console.Clear();
    for(int i = 0; i < listaDeBanda.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDeBanda[i]}");
    }
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoes();
}

void RemoverUmaBanda()
{
    Console.WriteLine($"Qual banda você quer remover: ");
    for(int i = 0; i < listaDeBanda.Count; i++)
    {
        Console.WriteLine($"Banda: [{i}]{listaDeBanda[i]}");
    }

    string removerItem = Console.ReadLine();
    int removerItemInt = int.Parse(removerItem);
    listaDeBanda.Remove(listaDeBanda[removerItemInt]);
    ExibirOpcoes();

    
}
ExibirOpcoes();

// Outro desafio
List<int> numeros = new List<int> { 10, 20, 30, 40, 50};

int totalNumeros = 0;
foreach(int numero in numeros)
{
    totalNumeros += numero;
    Console.WriteLine($"Total Atual: {totalNumeros}");
}