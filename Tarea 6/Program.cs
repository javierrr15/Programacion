using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte i, j, numAlumn, salones;
            double sumaCalif = 0, sumaCalifSalon, totalAlumn = 0, promedio, califMin = 10, califMax = 0;

            Console.WriteLine("Ingrese el numero de salones: ");
            salones = Convert.ToByte(Console.ReadLine());

            double[][] calif = new double[salones][];
            Console.WriteLine("  ");
            for (i = 0; i < salones; i++) { 

            Console.WriteLine("Cuantos alumnos tiene el salon {0}: ", i+1);
            numAlumn = Convert.ToByte(Console.ReadLine());
                totalAlumn += numAlumn;
                calif[i] = new double[numAlumn];
           

             }
            Console.WriteLine("  ");

            double[] califMinSalon = new double[salones];
            double[] califMaxSalon = new double[salones];
            double[] promedioSalon = new double [salones];
            for (i = 0; i < salones; i++)
            {
                sumaCalifSalon = 0;
                califMin = 10; 
                califMax = 0;
                Console.WriteLine("Salon  n°{0}", i + 1);

                for (j = 0; j < calif[i].Length; j++)
             {
                    Console.WriteLine("Ingrese calificacion del alumno {0}", j + 1);

                    calif[i][j] = Convert.ToDouble(Console.ReadLine());
                    sumaCalif += calif[i][j];
                    sumaCalifSalon+= calif[i][j];
                    if (calif[i][j] < califMin )
                            {

                        califMin=calif[i][j];   
                    }
                    califMinSalon[i] = califMin;
                    if (calif[i][j] > califMax)
                    {

                        califMax = calif[i][j];
                    }
                    califMaxSalon[i] = califMax;
                }
                promedioSalon[i] = sumaCalifSalon / calif[i].Length;
            
            }
            promedio = sumaCalif / totalAlumn;

            for (i = 0; i < salones; i++)
            {
              
                for (j = 0; j < calif[i].Length; j++)
                {
                   
                    if (calif[i][j] < califMin)
                    {

                        califMin = calif[i][j];
                    }
                   
                    if (calif[i][j] > califMax)
                    {

                        califMax = calif[i][j];
                    }
                 
                    }
                    }
            Console.WriteLine("  "); 
            Console.WriteLine("  ");
            Console.WriteLine("DATOS DE LA ESCUELA");
            Console.WriteLine("  ");
            for (i = 0; i < salones; i++)
            {

                Console.WriteLine("Salon  n°{0}", i + 1);

                for (j = 0; j < calif[i].Length; j++)
                {

                 Console.WriteLine("El alumno {0} tiene {1} de nota", j + 1, calif[i][j]);
                }
            }
            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("INFORMACION SALÓN {0}", i+1);
                Console.WriteLine("  ");
                Console.WriteLine("Calificacion minima  {0}, Calificacion Maxima {1}", califMinSalon[i], califMaxSalon[i]);
                Console.WriteLine("  ");
                Console.WriteLine("Promedio {0}", promedioSalon[i]);
            }
            Console.WriteLine("  ");
            Console.WriteLine("El promedio es {0}",promedio); 
            Console.WriteLine("La calificacion minima es {0}", califMin);
            Console.WriteLine("La calificacion maxima es {0}", califMax);
        }
    }
}

