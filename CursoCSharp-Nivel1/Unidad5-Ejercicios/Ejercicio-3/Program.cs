using System;

namespace ejercicio_3
{
    class programa
    {
        static void Main(string[] args)
        {
            // Hacer un programa para recibir listas de números positivos que están separadas entre sí por un 
            //cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene 
            //cada lista.
            int n, con =0, listaPos = 0;
            do
            {
                listaPos++;
                Console.WriteLine("Ingrese numero");
                n = int.Parse(Console.ReadLine());
                while (n > 0)
                {
                    con++;
                    n = int.Parse(Console.ReadLine());
                }
                    
                
            Console.WriteLine("la cantidad de numeros del grupo: " + listaPos + " son " + con);
            } while (n != 0);




        }
    }
}