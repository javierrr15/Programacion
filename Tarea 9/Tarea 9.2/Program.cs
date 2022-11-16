using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            string cadenaFechaNacimiento;
            DateTime dateTimeFechaNacimiento;

            
            Console.Write("Dime la fecha de tu nacimiento (día mes y año) y te diré que día de la semana era: ");
            cadenaFechaNacimiento = Console.ReadLine();

            dateTimeFechaNacimiento = DateTime.Parse(cadenaFechaNacimiento);

            Console.WriteLine($"Naciste un {dateTimeFechaNacimiento.ToString("dddd")}");
        }
    }
}
