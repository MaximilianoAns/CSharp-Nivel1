using System;

namespace TPFinal_Ans
{
    class Program
    {
        static void Main(string[] args)
        {
             //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
            //A partir de dichos datos informar:

            //a. El mayor de los números pares.
            //b. La cantidad de números impares.
            //c. El menor de los números primos.

           // Nota: evaluar el uso de una función que analice si un número dado es primo o no 
           // y que devuelva true o false según corresponda.

           // Entregar carpeta comprimida del proyecto con el TP resuelto.
            //Poner nombre tanto al proyecto como al zip: TP1_Apellido >> por ejemplo: TP1_SarFernandez

            int n, contadorPar = 0, maximoPar = 0, contadorImpar = 0, contadorPrimo = 0, minimoPrimo = 0;

            Console.WriteLine("INGRESE UN NUMERO:");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                if (n % 2 == 0){ 
                    contadorPar++;
                if (contadorPar == 1)
                    maximoPar = n;
                else if (n > maximoPar)
                    maximoPar = n;
                }else
                {
                    contadorImpar++;
                }
                bool esPrimo = primo(n);
                    if (esPrimo == true)
                        contadorPrimo++;
                    if (contadorPrimo == 1)
                         minimoPrimo = n;
                else if (n < minimoPrimo)
                {
                    minimoPrimo = n;
                }    
                Console.WriteLine("INGRESE OTRO: ** EL PROGRAMA TERMINA INGRESANDO UN CERO" );
                    n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("EL NUMERO MAYOR PAR ES: " + maximoPar);
            Console.WriteLine("LA CANTIDAD DE IMPARES SON: " + contadorImpar);
            Console.WriteLine("EL MINIMO IMPAR ES: " + minimoPrimo);
        }
            static bool primo (int n){
                int contador = 0;
                for (int x = 1; x <= n; x++)
                {
                    if (n % x == 0)
                       contador++;
                }
                if (contador == 2)
                    return true;
                else
                    return false;
            }
                
                
                
                
    }
}
