using System;

namespace PostoDescontoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite qual tipo de combustível foi comprado: (A) Álcool / (G) Gasolina");
            string combustivel = Console.ReadLine().ToUpper();

            switch (combustivel)
            {
                case "A":
                    Console.WriteLine("Quantos litros foram comprados?");
                    float litrosA = float.Parse(Console.ReadLine());
                    double valorAlcool = litrosA * 4.90;

                    if (litrosA <= 20)
                    {
                        double desconto = valorAlcool * 0.03;
                        double total = valorAlcool - desconto;
                        Console.WriteLine($"O valor a ser pago é: R$ {total}");
                    }
                    else if (litrosA > 20)
                    {
                        double desconto = valorAlcool * 0.05;
                        double total = valorAlcool - desconto;
                        Console.WriteLine($"O valor a ser pago é: R$ {total}");
                    }
                    break;

                case "G":
                    Console.WriteLine("Quantos litros foram comprados?");
                    float litrosB = float.Parse(Console.ReadLine());
                    double valorGasolina = litrosB * 5.30;

                    if (litrosB <= 20)
                    {
                        double desconto = valorGasolina * 0.03;
                        double total = valorGasolina - desconto;
                        Console.WriteLine($"O valor a ser pago é: R$ {total}");
                    }
                    else if (litrosB > 20)
                    {
                        double desconto = valorGasolina * 0.05;
                        double total = valorGasolina - desconto;
                        Console.WriteLine($"O valor a ser pago é: R$ {total}");
                    }
                    break;
                    
                default:
                    Console.WriteLine("Combustível inválido!");
                    break;
            }
        }
    }
}
