using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {   //Hacer un programa para solicitar dos números y 
            //luego calcule y emita la suma en pantalla.

            int a, b, resultado;

            Console.WriteLine("Ingrese numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero");
            b = int.Parse(Console.ReadLine());
            resultado = a *b;
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}

