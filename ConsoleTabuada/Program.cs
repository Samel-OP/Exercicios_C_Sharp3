using System;

namespace ConsoleTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;

            for (var u = 1; u <= 10; u++)
            {
                Console.WriteLine($"\n- Tabuada do {u} - \n");
                for (int i = 1; i <= 10; i++)
                {
                    int multiplicar = i;
                    int resultado = (numero) * multiplicar;
                    Console.WriteLine($"{numero} x {multiplicar} = {resultado}");
                }
                Console.WriteLine($"\n==================\n");
                numero++;
            }
        }
    }
}
