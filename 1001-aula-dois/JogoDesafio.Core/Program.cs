using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numberRandom = random.Next(1, 101);
        int answerUserInt = -1;

        Console.WriteLine("Tente adivinhar o número entre 1 e 100!");

        do
        {
            Console.Write("Digite um número: ");
            string? answerUser = Console.ReadLine();

            // Verifica se é um número válido antes de tentar converter
            if (int.TryParse(answerUser, out answerUserInt))
            {
                // Verifica se o número está no intervalo correto
                if (answerUserInt < 1 || answerUserInt > 100)
                {
                    Console.WriteLine("Número fora do intervalo! Digite um valor entre 1 e 100!");
                    continue;
                }

                if (answerUserInt < numberRandom)
                {
                    Console.WriteLine("É maior!");
                }
                else if (answerUserInt > numberRandom)
                {
                    Console.WriteLine("É menor!");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Digite um número válido.");
            }

        } while (answerUserInt != numberRandom);

        Console.WriteLine($"Parabéns! Você acertou o número {numberRandom}.");
    }
}
