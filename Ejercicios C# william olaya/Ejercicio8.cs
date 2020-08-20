using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("Numeros del 1 al 100: ");
            while(num <= 100)
            {
                Console.WriteLine(num);
                num+=1;
            }
            Console.ReadKey();
        }
    }
}
