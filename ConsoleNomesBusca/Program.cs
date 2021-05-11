using System;

namespace ConsoleNomesBusca
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;

            string[] nomesPergunta = new string[10];

            bool refazer = false;

            while (refazer == false)
            {
                var u = 0;

                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º nome:");
                    nomesPergunta[i] = Console.ReadLine().ToLower();
                }

                foreach (var item in nomesPergunta)
                {
                    Console.WriteLine($"{u}º nome: {nomesPergunta[u]}");
                    u++;
                }

                Console.WriteLine("Está correto os nomes fornecidos? (s) se sim e (n) se não");
                string correto = Console.ReadLine().ToLower();

                if (correto == "s")
                {
                    Console.WriteLine("Tudo OK");
                    refazer = true;
                }

                else
                {
                    Console.WriteLine("Refaça o formulário!");
                    refazer = false;
                }
            }
        }
    }
}