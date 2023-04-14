using System;

namespace ejercicio_3
{
    class programa
    {
        static void Main(string[] args)
        {
               //Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla 
           //cuántos de esos números son primos.
           int n, con = 0, numPrimos = 0;
           for (int x = 0; x < 10; x++)
           {
                Console.WriteLine("Ingrese numero: ");
                n = int.Parse(Console.ReadLine());

                if (n % 2 ==0)
                {
                    con++;
                }
                if (con == 2)
                {
                    numPrimos++;
                }
           }
           Console.WriteLine("La cantidad de numeros primos son: " + numPrimos); 




        }
    }
}