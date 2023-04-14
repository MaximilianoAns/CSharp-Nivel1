using System;

namespace ejercicio_3
{
    class programa
    {
        static void Main(string[] args)
        {
             //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas 
            //personas mayores a 18 años.

            int n, mayor = 0, promedio = 0, promedioTotal;
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingresar edad: ");
                n = int.Parse(Console.ReadLine());
                if (n > 18)
                {
                    mayor += n;
                    promedio++;
                }
            }
            promedioTotal = mayor / promedio;
           
            Console.WriteLine("El promedio de las personas mayores a 18 son: " + promedioTotal);




        }
    }
}