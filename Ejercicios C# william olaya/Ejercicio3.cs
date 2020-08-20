using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre = "";
            int edad = 0;

            Console.WriteLine("Ingrese su Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrasa tu edad: ");
                edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + " años");
            Console.ReadKey();
        }
    }
}
