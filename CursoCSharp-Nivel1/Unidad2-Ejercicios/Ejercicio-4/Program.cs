using System;

namespace ejercicio_3
{
    class programa
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números distintos y luego mostrar 
            //por pantalla el menor de ellos.
            int a, b, c, d;

            Console.WriteLine("Ingrese numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese uno mas: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo: ");
            d = int.Parse(Console.ReadLine());
            if (a <= b)
            {
                b = a;
            }
            if (b <= c)
            {
                c = b;
            }
            if (c <= d )
            {
                d = c;
            }
            Console.WriteLine("El numero menor ingresado es: " + d);








        }
    }
}