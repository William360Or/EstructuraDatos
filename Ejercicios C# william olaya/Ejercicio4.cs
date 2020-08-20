using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El numero " + num1 + " es mayor que el numero " + num2);
            }
            else if(num1 < num2){
                Console.WriteLine("El numero " + num2 + " es mayor que el numero " + num1);
            }
            else
            {
                Console.WriteLine("Los numeros ingresados son iguales");
            }

            Console.ReadKey();
        }
    }
}
