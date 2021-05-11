using System;

namespace ConsoleNumerosInverso
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];

            for (var i = 0; i < 15; i++)
            {
                Console.WriteLine($"Escreva o {i + 1}° numero:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (var u = 15; u > 0;)
            {
                Console.WriteLine($"numero: {u}");
                u--;
            }
        }
    }
}
