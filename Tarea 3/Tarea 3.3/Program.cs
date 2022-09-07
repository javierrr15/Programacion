using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutos = 0;

            Console.WriteLine("Cuantos minutos ha permanecido estacionado?: ");
            minutos = Convert.ToInt32(Console.ReadLine());

            if 
                (minutos <= 60) {
                Console.WriteLine("Usted debe $5.00 Dolares por permanecer {0} minutos",minutos);
            }
                else
            if (minutos > 60 && minutos < 120)
            {
                Console.WriteLine("Usted debe $15.00 Dolares por permanecer {0} minutos", minutos);
            }
                else
            if (minutos >= 120)
            {
                Console.WriteLine("Usted debe $40.00 Dolares por permanecer {0} minutos", minutos);
            }

        }

}
}

