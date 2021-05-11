using System;

namespace ConsoleNomesBusca
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;

            string[] nomesPergunta = new string[10];

            bool encontrar = false;

            while (encontrar == false)
            {

                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º nome:");
                    nomesPergunta[i] = Console.ReadLine().ToLower();
                }

                Console.Write("Escreva o nome que deseja buscar: ");
                string correto = Console.ReadLine().ToLower();

                foreach (var item in nomesPergunta)
                {
                    if (correto == item)
                    {
                        encontrar = true;
                    }
                }

                if (encontrar == true)
                {
                    Console.WriteLine("ACHEI!");
                    encontrar = true;
                }

                else
                {
                    Console.WriteLine("NÃO ACHEI");
                    encontrar = true;
                }
            }
        }
    }
}