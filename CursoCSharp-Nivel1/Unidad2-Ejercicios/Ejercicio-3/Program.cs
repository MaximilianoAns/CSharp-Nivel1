using System;

namespace ejercicio_3
{
    class programa
    {
        static void Main(string[] args)
        {
            //Una casa de video juegos otorga un descuento dependiendo del importe de la 
            //compra realizada según los siguientes valores:

                //Si el importe es menor a ARS 1000, no hay descuento.
                //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
                //Si el importe es ARS 5000 o más, aplica un descuento del 18%.

            //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla 
            //el importe final con el descuento que corresponda.
            float importe;
            Console.WriteLine("Ingrese importe de la compra: ");
            importe = float.Parse(Console.ReadLine());
                
            if (importe > 5000)
            {
                importe = importe * 0.82F;
                Console.WriteLine("El total de la compra con 18% de descuento es: " + importe);
            }
            else if(importe >= 1000 && importe < 5000)
            {

                importe = importe * 0.90F;
                Console.WriteLine("El total de la compra con 10% de descuento es: " + importe);
            }
            else{
                Console.WriteLine("NO hay descuento");
            }
           
        }
    }
}