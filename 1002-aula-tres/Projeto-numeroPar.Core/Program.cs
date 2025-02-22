using System.ComponentModel;

List<int> numerosInteiros = new List<int> {10, 2,3,7, 65, 98, 11, 37, 83, 71, 46};

for (int i = 0; i < numerosInteiros.Count; i++)
{
    if(numerosInteiros[i] % 2 == 0)
    {
        Console.Write($"{numerosInteiros[i]} ");
    }
}
Thread.Sleep(2000);
Console.Clear();

foreach( int numero in numerosInteiros)
{
    if (numero % 2 == 0)
    {
        Console.Write($"{numero} ");
    }
}