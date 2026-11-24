using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticarEjemplosArreglosListasDicionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaracion de un arreglos 
          /*/  int[] notas = {85, 90, 78, 92, 88 };

            Console.WriteLine(notas[0]);
            Console.WriteLine(notas[2]);
            Console.WriteLine(notas.Length);
          */
            // arreglos recorrido
            
            string[] nombres = { "Angel", "Lucas", "Diegopo", "Nando" };

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"{i}: {nombres[i]}");
                Console.WriteLine(nombres.Length);
            }

            Console.ReadKey();

        }
    }
}
