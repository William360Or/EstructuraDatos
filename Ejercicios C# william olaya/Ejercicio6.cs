using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio = 0;
            int formaPago = 0;
            double numcuenta = 0;

            Console.WriteLine("Ingrese el precio del producto:");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite 1 si es pago en efectivo, Si el pago es con tarjeta digite 2");
            formaPago = int.Parse(Console.ReadLine());

            if (formaPago==1)
            {
                Console.WriteLine("El precio del producto es " + precio + " la forma de pago fue en efectivo");
            }
            else if (formaPago==2)
            {
                Console.WriteLine("Ingrese el numero de cuenta: ");
                numcuenta = double.Parse(Console.ReadLine());
                Console.WriteLine("El precio del producto es:" + precio + " la forma de pago fue por tarjeta a la cuenta: "+numcuenta);
            }
            else
            {
                Console.WriteLine("El medio de pago ingresado no es valido");
            }

            Console.ReadKey();

        }
    }
}
