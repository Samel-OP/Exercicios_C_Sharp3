using System;

namespace ConsoleDezValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Escreva 10 valores:");

            int[] valores = new int[10];

            for (var i = 0; i < valores.Length; i++)
            {
                Console.Write($"O {i + 1}º valor é: ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(valores);

            int valorMaior = valores.GetUpperBound(0);
            int valorMenor = valores.GetLowerBound(0);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"O maior valor é: {valores[valorMaior]}");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"O menor valor é: {valores[valorMenor]}");
        }
    }
}
