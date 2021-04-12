using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorSolicitado, quantidadeParcelas, rendaMensal;
            double porcentagemUm, porcentagemDois, porcentagem;
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nOlá cliente, vamos começar a tratar do seu pedido de empréstimo! Para isso, digite: \n");
            Console.ResetColor();

            Console.Write("Digite o valor solicitado: ");
            valorSolicitado = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("A quantidade de parcelas desejada: ");
            quantidadeParcelas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sua renda mensal: ");
            rendaMensal = Convert.ToDouble(Console.ReadLine());

            porcentagemUm = 30 / 10;
            porcentagemDois = rendaMensal / 10; 
            porcentagem = porcentagemUm * porcentagemDois; 
            
            if (valorSolicitado > porcentagem)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nNão é possível fazermos um empréstimo de mais de 30% da rua renda, perdão.\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\nÉ possível fazermos um empréstimo de {valorSolicitado} reais com {quantidadeParcelas} parcelas. \n");
            }

            Console.ResetColor();

        }
    }
}
