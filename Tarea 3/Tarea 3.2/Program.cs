using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int  numero;

            Console.WriteLine("Ingrese un numero para comprobar si es par o impar: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0) 

            Console.WriteLine("El numero {0} es par",numero);

            else
                Console.WriteLine("El numero {0} es impar",numero
                  );    

        }
    }
}
