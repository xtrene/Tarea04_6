using System;

namespace Tarea04_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio = -1;
            string formaPago = "";
            string cuenta = "";
            do
            {
                Console.WriteLine("Introduce el precio del producto: ");
                precio = Convert.ToInt32(Console.ReadLine());
            }
            while (precio <= 0);

            do
            {
                Console.WriteLine("Introduce la forma de pago (efectivo o tarjeta): ");
                formaPago = Console.ReadLine();
            }
            while (formaPago != "efectivo" && formaPago != "tarjeta");

            if (formaPago == "tarjeta")
            {
                Console.WriteLine("Introduzca su número de cuenta: ");
                cuenta = Console.ReadLine();
                Console.WriteLine("Se ha realizado un cargo de {0} euros en su cuenta {1}", precio, cuenta);
            }
            else
            {
                Console.WriteLine("Ha realizado un pago de {0} euros en efectivo.",precio);
            }

            Console.WriteLine("Gracias por su compra...");

            Console.ReadKey();
        }
    }
}
