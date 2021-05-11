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

            if (votar >= 16)
            {
                Console.WriteLine("Você poderá votar esse ano!");
            }
            else
            {
                Console.WriteLine("Você não vai poder votar esse ano!");
            }
        }
    }
}
