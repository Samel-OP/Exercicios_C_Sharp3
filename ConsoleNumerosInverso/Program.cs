using System;

namespace ConsoleNumerosInverso
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];

            Console.WriteLine($"Insira {numeros.Length} numeros");

            for (var i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Escreva o {i + 1}° numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (var u = numeros.Length - 1; u >= 0; u--)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"numero: {numeros[u]}");
            }
        }
    }
}
