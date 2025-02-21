// Desafio Aula
Console.Write("Nota: ");
string notaMediaString = Console.ReadLine()!;
int notaMediaInt = int.Parse(notaMediaString);
if(notaMediaInt >= 5)
{
    Console.WriteLine("Nota suficiente para aprovação!");
} else{
    Console.WriteLine("Você reprovou!");
}

List <string> nomes = new List<string> {"C#", "Java", "JavaScript"};
Console.WriteLine(nomes[0]);

//programa que o dado de entrada  de dados de um número n inteiro

string posicaoDesejada = Console.ReadLine();

int posicaoDesejadaInt = int.Parse(posicaoDesejada);

List <int> listaDeNumeros = new List<int> {1, 23, 54, 65, 92, 3, 8, 77};
Console.WriteLine(listaDeNumeros[posicaoDesejadaInt]);