using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Resolução do teste de avaliação diagnóstica
/// </summary>
namespace Campismo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] espacos = new bool[20];
            for (int i = 0; i < espacos.Length; i++)
                espacos[i] = false;

            int espacosLivres = espacos.Length;
            while (true)
            {
                Console.Write("Qual o espaço a ocupar?");
                int novoEspaco = Convert.ToInt32(Console.ReadLine());
                if(novoEspaco<1 || novoEspaco > 20)
                {
                    Console.WriteLine("Espaço não é válido.");
                    continue;
                }
                if (espacos[novoEspaco - 1])
                {
                    Console.WriteLine("Espaço ocupado.");
                    continue;
                }
                espacos[novoEspaco - 1] = true;
                espacosLivres--;
                Console.WriteLine("Tem {0} espaços livres e {1} espaços ocupados.", espacosLivres, espacos.Length - espacosLivres);
                if (espacosLivres == 0)
                    break;  
            }
            Console.WriteLine("Parque está cheio");
            Console.ReadKey();
        }
    }
}
