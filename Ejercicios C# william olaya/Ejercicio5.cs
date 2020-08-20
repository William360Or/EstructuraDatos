using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            String dia = "";

            Console.WriteLine("Ingrese el dia de la semana");
            dia = Console.ReadLine();
            switch (dia.ToLower())
            {
                case "lunes":
                    Console.WriteLine("Aun no es fin de semana :( ");
                    break;
                case "martes":
                    Console.WriteLine("Aun no es fin de semana :( ");
                    break;
                case "miercoles":
                    Console.WriteLine("Aun no es fin de semana :( ");
                    break;
                case "jueves":
                    Console.WriteLine("Aun no es fin de semana :( ");
                    break;
                case "viernes":
                    Console.WriteLine("Aun no es fin de semana :( ");
                    break;
                case "sabado":
                    Console.WriteLine("Es fin de semana :) ");
                    break;
                case "domingo":
                    Console.WriteLine("Es fin de semana :) ");
                    break;
                default:
                    Console.WriteLine("Error el dia de la semana ingresado no existe");
                    break;
            }
            Console.ReadKey();
        }
    }
}
