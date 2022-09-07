using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte mes;

            Console.Write("Ingrese el numero para ver su correspondiente mes: ");
            mes = Convert.ToByte(Console.ReadLine());

            switch(mes)
            {
                case 1 : Console.Write("El numero {0} corresponde a Enero", mes);
                    break;
                case 2:
                    Console.Write("El numero {0} corresponde a Febrero", mes);
                    break;
                case 3:
                    Console.Write("El numero {0} corresponde a Marzo", mes);
                    break;
                case 4:
                    Console.Write("El numero {0} corresponde a Abril", mes);
                    break;
                case 5:
                    Console.Write("El numero {0} corresponde a Mayo", mes);
                    break;
                case 6:
                    Console.Write("El numero {0} corresponde a Junio", mes);
                    break;
                case 7:
                    Console.Write("El numero {0} corresponde a Julio", mes);
                    break;
                case 8:
                    Console.Write("El numero {0} corresponde a Agosto", mes);
                    break;
                case 9:
                    Console.Write("El numero {0} corresponde a Septiembre", mes);
                    break;
                case 10:
                    Console.Write("El numero {0} corresponde a Octubre", mes);
                    break;
                case 11:
                    Console.Write("El numero {0} corresponde a Noviembre", mes);
                    break;
                case 12:
                    Console.Write("El numero {0} corresponde a Diciembre", mes);
                    break;
                default:
                    Console.Write("El numero {0} no es valido", mes);
                    break;
            }

    }
}
}

