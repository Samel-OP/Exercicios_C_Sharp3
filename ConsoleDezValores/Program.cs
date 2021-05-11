using System;

namespace ConsoleDezValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Escreva 10 valores:");

            int[] valores = null;
            valores = new int[10];

            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"O {i + 1}º valor");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(valores);

            int valorMaior = valores.GetUpperBound(0);
            int valorMenor = valores.GetLowerBound(0);

            Console.WriteLine($"O maior valor é: {valores[valorMaior]}");
            Console.WriteLine($"O menor valor é: {valores[valorMenor]}");
        }
    }
}
