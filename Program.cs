using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor solicitado do empréstimo: ");
            double emprestimo=Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a quantidade de parcelas desejada: ");
            double parcela=Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a sua renda mensal: ");
            double renda=Convert.ToDouble(Console.ReadLine());

            double resultado=(30 * renda) / 100;
            
            Console.Clear();

            if(resultado>parcela)
            Console.WriteLine("Empréstimo negado");
            else
            Console.WriteLine("Empréstimo aprovado");

        




        }
    }
}
