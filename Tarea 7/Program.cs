using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellidos, direccion;
            double saldo, deposito;
            byte opcion;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese su dirección: ");
            direccion = Console.ReadLine();
            Console.WriteLine("Ingrese su saldo: ");
            saldo = Convert.ToDouble(Console.ReadLine());

            CuentaBancaria cuentaBancaria = new CuentaBancaria(nombre,apellidos,saldo,direccion);

            
            do {
                Console.WriteLine(" ");
           
                Console.WriteLine(" ");
                Console.WriteLine("Bienvenido, elija una opcion: ");
                Console.WriteLine("1.Deposito ");
                Console.WriteLine("2.Retiro ");
                Console.WriteLine("3.Consulta saldo ");
                Console.WriteLine("4.Mostrar Info de la cuenta ");
                Console.WriteLine("5.Salir ");
                Console.WriteLine(" "); 
          
                Console.WriteLine(" ");

                opcion = Convert.ToByte(Console.ReadLine());
                    
            

            switch (opcion)
            {

                case 1:

                    Console.WriteLine("Cuanto desea depositar: ");
                    deposito = Convert.ToDouble(Console.ReadLine());
                    cuentaBancaria.Deposito(deposito);
                    break;
                case 2:
                    Console.WriteLine("Cuanto desea retirar: ");
                    deposito = Convert.ToDouble(Console.ReadLine());
                    cuentaBancaria.Retiro(deposito);
                    break;
                case 3:
                    cuentaBancaria.ConsultaSaldo();
                    break;
                case 4:
                    Console.WriteLine(cuentaBancaria.ToString());
                    break;
                }
            }
            while (opcion != 5) ;

            }
    }


    class CuentaBancaria
    {
        private string nombre, apellidos, direccion;
        private double saldo;

        public CuentaBancaria(string nombrePa, string apellidosPa, double saldoPa, string direccionPa)
        {
            nombre = nombrePa;
            apellidos = apellidosPa;
            direccion = direccionPa;
            saldo = saldoPa;
        }
        public double Deposito(double depositoPa)
        {
            saldo += depositoPa;
            return saldo;
         
        }
        public double Retiro(double depositoPa)
        {
            if (saldo > depositoPa)
            {
                saldo -= depositoPa;
                return saldo;
            }
            else 
            {

               Console.WriteLine("No tiene suficiente saldo");
                return saldo;
            }
        }
    
        public void ConsultaSaldo()
        {
            Console.WriteLine("Su saldo es {0}",saldo); // asd
        }
        public override string ToString()
        {

            string mensaje;
            mensaje = "Nombre cliente :" + " "+ nombre + " " + apellidos + "\nDireccion en: " + ""+ direccion;
            return mensaje;
                }
}
}





