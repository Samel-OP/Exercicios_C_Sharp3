using System;

namespace ConsoleProdutoDesconto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto:");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite a quantidade do produto:");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor unitário do produto:");
            double valorProduto = double.Parse(Console.ReadLine());

            if (quantidadeProduto <= 5)
            {
                double desconto = (valorProduto * quantidadeProduto) * 0.02;
                double total = (valorProduto * quantidadeProduto) - desconto;
                Console.WriteLine($"Preço de cada {nomeProduto} é: R${valorProduto}");
                Console.WriteLine($"Desconto: R${desconto}");
                Console.WriteLine($"Total a pagar é: R${total}");
            }
            else if (quantidadeProduto > 5 && quantidadeProduto <= 10)
            {
                double desconto = (valorProduto * quantidadeProduto) * 0.03;
                double total = (valorProduto * quantidadeProduto) - desconto;
                Console.WriteLine($"Preço de cada {nomeProduto} é: R${valorProduto}");
                Console.WriteLine($"Desconto: R${desconto}");
                Console.WriteLine($"Total a pagar é: R${total}");
            }
            else if (quantidadeProduto > 10)
            {
                double desconto = (valorProduto * quantidadeProduto) * 0.05;
                double total = (valorProduto * quantidadeProduto) - desconto;
                Console.WriteLine($"Preço de cada {nomeProduto} é: R${valorProduto}");
                Console.WriteLine($"Desconto: R${desconto}");
                Console.WriteLine($"Total a pagar é: R${total}");
            }
        }
    }
}
