using System;

namespace ejercicio_2
{
    class programa
    {
        static void Main(string[] args)
        {
               //Un importante negocio de desinfectante líquido realiza descuentos dependiendo 
                //de la cantidad de litros vendidos según la siguiente escala:

            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

        //Hacer un programa que solicite el ingreso del importe total de la venta y 
        //la cantidad de litros vendidos y calcule y emita el importe con el descuento aplicado. 
            float litros, descuento, cantidadLitros;
            Console.WriteLine("Ingrese litros vendidos: ");
            litros = float.Parse(Console.ReadLine());
            if (litros >= 101 && litros < 300)
            {
                cantidadLitros = litros;
                descuento = litros * 0.90F;
                Console.WriteLine("El total del importe con 10% de descuento es: " + descuento + " y la cantidad de litros vendidos son: " + cantidadLitros);
            }
            else if(litros < 100)
            {
                Console.WriteLine("NO hay descuento");
            }
            if(litros >= 301 && litros <= 500)
            {
                cantidadLitros = litros;
                descuento = litros * 0.85F;
                Console.WriteLine("El total del importe con 15% de descuento es: " + descuento + " y la cantidad de litros vendidos son: " + cantidadLitros);
            }
            else if(litros > 500)
            {
                cantidadLitros = litros;
                descuento = litros * 0.75F;
                Console.WriteLine("El total del importe con 25% de descuento es: " + descuento + " y la cantidad de litros vendidos son: " + cantidadLitros);
            }



        }
    }
}