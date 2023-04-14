using System;

namespace ejercicio_3
{
    class programa
    {
        static void Main(string[] args)
        {
                 //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es 
            //primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se 
            //ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.
            int n, acu = 0, contadorPrimo = 0, promedio = 0;
            Console.WriteLine("Ingrese numero: ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                Console.WriteLine("Ingrese numero: ");
                n = int.Parse(Console.ReadLine());
                if (primo(n))
                {
                    acu += n;
                    contadorPrimo++;
                }
                promedio = acu / contadorPrimo;

            }
            Console.WriteLine("El promedio de los primos son: " + promedio);
        }
        static bool primo(int a){
        
            int con = 0;

            for (int x = 1; x <= a; x++)
            {
                if(a % x == 0)
                con++;                
            }
            if(con == 2){
                    return true;
                }else{
                    return false;
                }
        }
            









        

    }   
}