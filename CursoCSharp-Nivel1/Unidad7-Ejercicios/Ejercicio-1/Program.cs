using System;

namespace ejercicio_1
{
    class programa
    {
        static void Main(string[] args)
        {
            //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el 
            //producto de ambos. Luego hacer un programa que pida el precio de un artículo y la cantidad 
            //vendida y muestre por pantalla el monto total a pagar. Usar la función.
            int precio, venta, totalaPagar;
            Console.WriteLine("Ingrese el precio del articulo: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida");
            venta = int.Parse(Console.ReadLine());
            totalaPagar = producto(precio,venta);
            Console.WriteLine("El monto a pagar es: " + totalaPagar);
        }

        static int producto (int a, int b)
        {
            int producto;
            producto = a * b;
            return  producto;
            

        }
    }
}











