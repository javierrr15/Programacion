using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Se crean las variables que son el tamaño de los 3 lados de un triangulo y el perimetro
            double a, b, c, perimetro;


            Console.Write("Para calcular el perimetro de un triangulo indique la longitud de su base: ");
             a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ahora indique la longitud del lado izquierdo: ");

            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Por ultimo, indique la longitud del lado derecho: ");

            c = Convert.ToDouble(Console.ReadLine());

            perimetro = a + b + c;

            Console.WriteLine("El perimetro es {0}",perimetro); 
        }
    }
}
