using System;

namespace ejercicio_5
{
    class programa
    {
        static void Main(string[] args)
        {
           // Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los 
            //números pares y el mínimo de los números impares.

            int n, pares = 0, impar = 0, maxPar = 0, minImpar = 0;
            for (int x = 0; x < 5; x++)
            {
                
                Console.WriteLine("Ingrese numero: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    pares++;
                    if (pares == 1)
                    {
                        maxPar = n;
                    }
                    else if(n > maxPar)
                    {
                        maxPar = n;
                    }
                }
                else if(n % 2 != 0)
                {
                    impar++;
                    if (impar == 1)
                    {
                        minImpar = n;
                    }
                    else if(n < minImpar)
                    {
                        minImpar = n;
                    }
                }
            }
            Console.WriteLine("El numero maximo par es: " + maxPar);
            Console.WriteLine("El numero minimo impar es: " + minImpar);
                
                
               



           
            





        }
    }
}