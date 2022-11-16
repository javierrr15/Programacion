using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadenaInvertida = "";

            Console.WriteLine("Ingrese palabra y revisa si es pálindroma: ");
            string cadena = Console.ReadLine();
            char[] chars = cadena.ToCharArray();


            foreach (char letra in chars)
            {

                cadenaInvertida = letra + cadenaInvertida;
            }
            if (String.Equals(cadena, cadenaInvertida))
            {
                Console.WriteLine("La frase ingresada si es pálidroma");

            }
            else
            {
                Console.WriteLine("La palabra {0} y {1} no son iguales ", cadena, cadenaInvertida);
            }
        }
    }









}
