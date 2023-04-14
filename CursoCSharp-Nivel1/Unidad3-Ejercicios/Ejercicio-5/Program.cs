using System;

namespace ejercicio_3
{
    class programa
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los 
            //mismos se encuentran ordenados de forma decreciente.
            int a, b, c, d;
            Console.WriteLine("Ingrese numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese uno mas: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese ultimo: ");
            d = int.Parse(Console.ReadLine());

            if (a > b && c < b && d < c)
            {
                Console.WriteLine("Los numeros estan ordenado de forma decreciente");
            }
            else
            {
                Console.WriteLine("Los numeros NO es tan ordenados de forma decreciente");
            }




        }
    }
}