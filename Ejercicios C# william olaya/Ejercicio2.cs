using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre = "";
            string ciudad = "";

            Console.WriteLine("Ingrese su Nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la Ciudad: ");
            ciudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " Bienvenido a " + ciudad);
            Console.ReadKey();
        }
    }
}
