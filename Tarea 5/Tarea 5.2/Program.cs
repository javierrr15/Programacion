using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area,opcion;

            Console.WriteLine("Ingrese opcion ");
            Console.WriteLine("1.Calcular area de un circulo");
            Console.WriteLine("2.Calcular area de un cuadrado");
            Console.WriteLine("3.Calcular area de un triangulo");
            opcion = Convert.ToInt32(Console.ReadLine());

            while ((opcion < 1) || (opcion > 3));
            switch (opcion)
            {

                case 1:
                    Circulo();
                    break;
                case 2:
                    Cuadrado();
                    break;
                case 3:
                    Triangulo();
                    break;
        }
    }
        static void Circulo()
        {
        double radio, area;

            Console.WriteLine("Ingrese radio del circulo: ");
            radio = Convert.ToDouble(Console.ReadLine());

            area = (radio * radio ) * 3.14;

            Console.WriteLine("El area del circulo es {0}", area);
        }
        static void Cuadrado()
        {
         double area,lado1, lado2;

            Console.WriteLine("Ingrese magnitud del lado a: ");
            lado1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese magnitud del lado b: ");
            lado2 = Convert.ToDouble(Console.ReadLine());

            area = lado1 * lado2;

            Console.WriteLine("El area del cuadrado es {0}", area);
        }
        static void Triangulo()
        {
            double area, bas, altura;
            Console.WriteLine("Ingrese base del triangulo: ");
            bas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese altura del triangulo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            area = (bas * altura) / 2;
            Console.WriteLine("El area del triangulo es {0}", area);

        }
    }
}