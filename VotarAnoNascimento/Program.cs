using System;

namespace VotarAnoNascimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data do seu nascimento (Ano):");
            int data = int.Parse(Console.ReadLine());

            int votar = DateTime.Now.Year - data;

            if (votar >= 16 && votar < 18)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Você PODERÁ votar esse ano!");
            }
            else if (votar >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Você é DEVE votar esse ano!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Você NÃO pode votar esse ano!");
            }
        }
    }
}
