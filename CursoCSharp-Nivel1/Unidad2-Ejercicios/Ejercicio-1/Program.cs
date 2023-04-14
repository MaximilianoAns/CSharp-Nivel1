using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {   
           
            //Hacer un programa para ingresar un número y luego se emita por pantalla 
            //un cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.
            
            int a;

            Console.WriteLine("Ingrese numero: ");
            a = int.Parse(Console.ReadLine());
            if (a > 10)
            {
                Console.WriteLine("El numero es mayor a 10");
            }
            else
            {
                Console.WriteLine("El numero ingresado NO es mayor a 10");
            }


        }
    }
}