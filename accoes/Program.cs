using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, acumulado=0, pv, pc;

            Console.Write("Quantas ações comprou?");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.Write("Qual o preço de compra da ação nr {0}", i + 1);
                pc = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o preço de venda da ação nr {0}", i + 1);
                pv = Convert.ToInt32(Console.ReadLine());
                acumulado += (pv - pc);
            }
            Console.WriteLine("Acumulado {0}", acumulado);
            Console.ReadKey();
        }
    }
}
