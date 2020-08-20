using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)


        {

            Console.WriteLine("Numeros pares o divisibles por 3 del 1 al 100");
            for(int i=1; i<=100; i++)
            {
                if(i% 2 ==0 && i % 3 == 0)
                {
                    Console.WriteLine(i + " Es un numero par y divisible por tres");
                }
                else if (i % 2==0)
                {
                    Console.WriteLine(i + " Es un numero par");
                }
                else if(i % 3==0) {
                    Console.WriteLine(i + " Es un numero divisible por tres");
                }


            }
            Console.ReadKey();
        }
    }
}
