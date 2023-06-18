using System;
using System.Drawing;

namespace Recursividad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESE EL NUMERO A SUMAR");
            int valor = int.Parse(Console.ReadLine());
            Console.WriteLine(suma(valor) + "\nGRACIAS POR USAR EL PROGRAMA :)");
        }
        public static int suma(int n)
        {
            if (n == 1)
            {
                return n;
            }
            else
            {
                return n + suma(n-1);
            }
        }
    }
}
