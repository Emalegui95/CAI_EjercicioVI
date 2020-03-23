using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_EjercicioVI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la cuenta es: " + ((a+b)*(a-b)));
            Console.ReadKey();
        }
    }
}
