using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grados ;


            Console.WriteLine("Ingrese el grado del angulo para transformalo a radianes: ");
            grados = Convert.ToDouble(Console.ReadLine());
            Conversion(grados);
        }

        static void Conversion(double grados )
        {

            double radian;

            radian = grados * (3.14 / 180);
            Console.WriteLine("El angulo {0}° es equivalente a {1} radianes",grados, radian);
           




        }
    }
}

