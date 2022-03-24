using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_firstclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneira torneira = new Torneira();
            Console.WriteLine("Digite uma opção:");
            int escolha = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade:");
            int Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma opção:");
            int escolha = int.Parse(Console.ReadLine());

            if (torneira.Abrir(escolha) == true)
            {
                torneira.Fechar();
            }

            Console.WriteLine("Valor a pagar" + Calcular(preco,Quantidade));
            Console.WriteLine("A torneira está aberta?" + torneira.Estado);

        }


        static double Calcular(double valor, int quant)
        {
         return valor * quant;
        }

    }
}
