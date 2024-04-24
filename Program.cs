namespace Ejercicio10
{
    class Program
    {
        public static void Main(string[] args)
        {
            HashSet<int> enteros = new HashSet<int>();
            enteros.Add(3);
            enteros.Add(2);
            enteros.Add(7);
            enteros.Add(3);
            enteros.Add(0);
            enteros.Add(1);

            Console.WriteLine("Introduzca un numero: ");
            int respuesta=Convert.ToInt32(Console.ReadLine());

            if(enteros.Contains(respuesta))
            {
                Console.WriteLine("El numero introducido es correcto. " + respuesta);
            }
            else
            {
                Console.WriteLine("El numero introducido no existe. Esta eran las opciones: ");

                foreach(int entero in enteros)
                {
                    Console.WriteLine(entero);
                }
            }
        }
    }
}
