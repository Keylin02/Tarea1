using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = { 1, 2, 3, 4, 5 };
            int suma = 0;
            
            for (int i = 0; i < valores.Length; i++)
            {
                suma = suma + valores[i];  
            }

            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
