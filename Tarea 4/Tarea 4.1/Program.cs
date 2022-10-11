using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado=1 , resultadonegativo=1;
            int exponente, numero;

            Console.WriteLine("Ingrese un numero(base) para calcular su potencia:");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());


            if (exponente < 0)
            {
                exponente *=-1;
                
                for (int i = 1; i <=exponente; i++)
            {
               resultado *= numero;
               

                    resultadonegativo = ( 1 / resultado );

                }
                Console.WriteLine("{0} elevado a -{1} es {2}", numero, exponente, resultadonegativo);
            }
            


            else 
                
                for (int i = 1; exponente >= i; i++)
                {
                    resultado *= numero;
                    
                }
            Console.WriteLine("{0} elevado {1} es {2}", numero, exponente, resultado);
        }
    }
}
