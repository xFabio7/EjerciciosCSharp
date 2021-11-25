using System;

namespace EjerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1

            Console.WriteLine("Hola Nayra");

            //Ejercicio 2 

            int x = Convert.ToInt32(Console.ReadLine());
            int divisor = 2;

            while (x % divisor != 0)
            {
                divisor++;
            }

            if (divisor == x)
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No es primo");
            }

            //Ejercicio 3

            int total = 10;
            int[] numeros = new int[total];

            for (int i = 0; i < total; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write("{0} ", numeros[i]);
                }

                //Ejercicio 4

                int x1 = Convert.ToInt32(Console.ReadLine());
                int x2 = Convert.ToInt32(Console.ReadLine());
                int x3 = Convert.ToInt32(Console.ReadLine());
                int x4 = Convert.ToInt32(Console.ReadLine());

                int result = (x1 + x2 + x3 + x4) / 4;
                Console.WriteLine(result);

                //Ejercicio 5

                int n = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(n / b);
                Console.WriteLine(n % b);













            }
        }
    }
}
