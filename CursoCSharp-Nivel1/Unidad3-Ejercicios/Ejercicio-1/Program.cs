using System;

namespace ejercicio_1
{
    class programa
    {
        static void Main(string[] args)
        {
              //Hacer un programa que solicite el ingreso de dos números y luego calcular:
                //La resta si el primero es mayor que el segundo.
                //La suma si son iguales.
                //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente. 

            int a, b, resultado;
            Console.WriteLine("Ingrese numero: ");
            a = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese otro: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                resultado = a - b;
                Console.WriteLine("El resultado de la resta es: " + resultado);
            }
            if (a == b)
            {
                resultado = a + b;
                Console.WriteLine("El resultado de la suma es: " + resultado);
            }
            if (a < b)
            {
                resultado = a * b;
                Console.WriteLine("El resultado del producto es: " + resultado);
            }
            




        }
    }
}

