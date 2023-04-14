using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Hacer un programa para ingresar por teclado las tres notas de exámenes 
            //de un alumno y luego calcule y emita por pantalla el promedio final.

            int a, b, c, promedio;

            Console.WriteLine("Ingrese primera nota: ");
            a = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese tercera nota: ");
            b = int.Parse(Console.ReadLine());
             Console.WriteLine("Ingrese segunda nota: ");
            c = int.Parse(Console.ReadLine());

            promedio = (a + b + c) / 3;
            Console.WriteLine("El promedio final es: " + promedio);
            
        }
    }
}