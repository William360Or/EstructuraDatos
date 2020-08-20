using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int totalSuma = 0;

            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse (Console.ReadLine());
            
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer numero");
            num3 = int.Parse(Console.ReadLine());

            totalSuma = num1 + num2 + num3;

            Console.WriteLine("El resultado de la suma es: " + totalSuma);
            Console.ReadKey();
        }
    }
}
