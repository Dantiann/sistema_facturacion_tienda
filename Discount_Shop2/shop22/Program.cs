using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int articulosComprados;
            string nombreProducto;
            int cantidad;
            double precio;
            double valorParcial;
            double descuento;
            double dto;
            double subtotal;
            double total = 0;
            double valorParcialGeneral = 0;
            double descuentoGeneral = 0;

            Console.WriteLine("Digite la cantidad de articulos comprados:  ");
            articulosComprados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(".........................");

            for (int i = 1; i <= articulosComprados; i++)
            {
                Console.WriteLine("Ingrese el nombre del producto: ");
                nombreProducto = Console.ReadLine();

                Console.WriteLine("Ingrese la cantidad de " + nombreProducto + ":");
                cantidad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el precio de " + nombreProducto + ":");
                precio = Convert.ToDouble(Console.ReadLine());


                if (cantidad >= 1 && cantidad <= 5)
                {
                    descuento = 0;

                }
                else if (cantidad >= 6 && cantidad <= 10)
                {
                    descuento = 0.05;

                }
                else if (cantidad >= 11 && cantidad <= 20)
                {
                    descuento = 0.1;

                }
                else if (cantidad >= 21 && cantidad <= 30)
                {
                    descuento = 0.2;
                }
                else if (cantidad >= 31)
                {
                    descuento = 0.3;
                }
                else
                {
                    Console.WriteLine("Cantidad inválida");
                    continue;
                }

                valorParcial = cantidad * precio;
                dto = valorParcial * descuento;
                subtotal = valorParcial * (1 - descuento);

                valorParcialGeneral += valorParcial;
                descuentoGeneral += dto;
                total += subtotal;

                Console.WriteLine($"Valor parcial:    {valorParcial:C}");
                Console.WriteLine($"Descuento -{descuento * 100}%:   {dto:C}");
                Console.WriteLine($"Subtotal:         {subtotal:C}");
                Console.WriteLine(".........................");
            }


            Console.WriteLine($" ");
            Console.WriteLine($"**************************");
            Console.WriteLine($" ");

            Console.WriteLine($"Valor Parcial:             {valorParcialGeneral:C}");
            Console.WriteLine($"Ahorro en esta compra (-): {descuentoGeneral:C}");
            Console.WriteLine($"Total a pagar:             {total:C}");
            Console.WriteLine($" ");
            Console.WriteLine($"**************************");
            Console.ReadKey();




            Console.ReadKey();

        }

    }
}