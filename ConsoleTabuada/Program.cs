using System;

namespace ConsoleTabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;

            for (var u = 0; u < 10; u++)
            {
                
                for (int i = 1; i <= 10; i++)
                {
                    int multiplicar = i;
                    int resultado = (numero) * multiplicar;
                    Console.WriteLine($"Tabuada: {numero} x {multiplicar} = {resultado}");                                
                }

                  numero++;
            }
        }
    }
}
