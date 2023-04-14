using System;

namespace ejercicio_3
{
    class programa
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar cuatro números 
            //y luego mostrar por pantalla cuáles son mayores a 100.

            int a, b, c, d, numeroMenor, con =0;

            Console.WriteLine("Ingrese numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese uno mas: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo: ");
            d = int.Parse(Console.ReadLine());
            if (a > 100)
            {
                con++;
            }
            if (b > 100)
            {
                con++;
            }
            if (c > 100)
            {
                con++;
            }
            if (d > 100)
            {
                con++;
            }
            if (con != 0)
            {
                Console.WriteLine("La cantidad de numeros mayores a 100 son: " + con);
            }
           




        }
    }
}