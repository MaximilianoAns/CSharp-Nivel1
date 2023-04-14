namespace ejercicio_2
{
    class programa
    {
        static void Main(string[] args)
        {
                
            //Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
            //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores 
            //que son mayores al promedio.

            int [] numeros = new int[10];
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese numero:");
                numeros[x] = int.Parse(Console.ReadLine());
            }
            int acu = 0, promedio;
            for (int x = 0; x < 10; x++)
            {
                acu+= numeros[x];
            }
            promedio = acu / 10;

            Console.WriteLine("Los valores mayores son: " + promedio);




        }
    }
}