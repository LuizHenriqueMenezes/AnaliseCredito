using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorSolicitado, quantidadeParcelas, rendaMensal, valorParcela;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nOlá cliente, vamos começar a tratar do seu pedido de empréstimo! Para isso, digite: \n");
            Console.ResetColor();

            Console.Write("Digite o valor solicitado: ");
            valorSolicitado = Convert.ToDouble(Console.ReadLine());

            Console.Write("A quantidade de parcelas desejada: ");
            quantidadeParcelas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sua renda mensal: ");
            rendaMensal = Convert.ToDouble(Console.ReadLine());

            valorParcela = valorSolicitado / quantidadeParcelas;

            if (valorParcela > rendaMensal * 0.3)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNão é possível fazermos um empréstimo de mais de 30% da sua renda, perdão.\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\nÉ possível fazermos um empréstimo de {valorSolicitado:C} com {quantidadeParcelas} parcelas, sendo {valorParcela:C} cada. \n");
            }

            Console.ResetColor();

        }
    }
}
