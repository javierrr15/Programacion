using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double centigrados, farenheit;

            Console.Write("Ingrese temperatura en grados centigrados: ");

            centigrados = Convert.ToDouble(Console.ReadLine());

            farenheit = centigrados * 1.8 + 32;

            Console.WriteLine("La temperatura en farenheit es {0} ", farenheit);

        }
    }
}
