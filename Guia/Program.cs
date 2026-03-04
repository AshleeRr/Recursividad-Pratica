using System.Drawing;

namespace Guia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ejemplo 1, recorrer un arreglo

            int[] numeros = new int[] { 5, 5, 5, 2, 2, 6 };
            Recorrer(numeros);

            // ejemplo 2, sumar los elementos de un arreglo
            int resultado = Sumar(numeros);

            //ejemplo 3, factorial
            int factorial = Factorial(5);
            Console.WriteLine("Factorial> " + factorial);
        }

        // no retorna porque es void
        static void Recorrer(int[] arreglo, int posicion = 0)
        {
            if (posicion == arreglo.Length)
                return;

            Console.WriteLine(arreglo[posicion]);
            Recorrer(arreglo, posicion + 1);

        }

        static int Sumar(int[] arreglo,int posicion = 0)
        {
            if (posicion == arreglo.Length)
                return 0;// para que no afecte, sume cuando termine

            return arreglo[posicion] + Sumar(arreglo, posicion + 1); // si son objetos no poner ++
        }

        static int Factorial(int numero)
        {
            if (numero == 1)
                return numero;

            return numero * Factorial(numero - 1);
        }
    }
}
