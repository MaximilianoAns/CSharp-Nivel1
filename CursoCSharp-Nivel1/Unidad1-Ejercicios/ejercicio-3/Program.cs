using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)

        {  
            //Hacer un programa que permita ingresar los kilómetros existentes 
            //entre dos ciudades y la velocidad promedio de un vehículo. 
            //Calcular y emitir por pantalla el tiempo aproximado que 
            //demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
            
            float kilometros, distancia , tiempo;
            Console.WriteLine("Ingrese distancia");
            kilometros = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingre vel promedio:");
            distancia = float.Parse(Console.ReadLine());

            tiempo = kilometros / distancia;
            Console.WriteLine("El tiempo estimado sera:" + tiempo.ToString("0.00") + "Horas..");
        }
    }
}
