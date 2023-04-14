using System;

namespace ejercicio_3
{
    class programa
    {
        static void Main(string[] args)
        {
               //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de 
            //los dos primeros es mayor al producto del segundo con el tercero. 
            int a, b, c;
            Console.WriteLine("Ingrese numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el ultimo: ");
            c = int.Parse(Console.ReadLine());
            
            if ((a + b) > (b *c))
            {
                Console.WriteLine("La suma de los dos primeros es mayor al producto del segundo con el tercero");
            }
            else
            {
                Console.WriteLine("NO es mayor la suma de los primeros a relacion del producto del segundo con el tercero");
            }



        }
    }
}
