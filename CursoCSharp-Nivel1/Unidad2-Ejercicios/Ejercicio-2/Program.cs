using System;

namespace ejercicio_2
{
    class Program
    {

        static void Main (string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita un cartel por 
            //pantalla “Positivo” si el número es mayor a cero, “Negativo” si el número 
            //es menor a cero o “Cero” si el número es igual a cero.

            int a;
            Console.WriteLine("Ingrese numero:");
            a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("El numero ingresado es postivo");
            }
            else if (a < 0)
            {
                Console.WriteLine("El numero ingresado es negativo");
            }
            else
            {
                Console.WriteLine("El numero ingresado es igual a cero");
            }
            
                
            



        }



    }











    
}