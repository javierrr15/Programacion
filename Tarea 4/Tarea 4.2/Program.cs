using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,divisor,numerodivisores=0;

            for(i=2 ; i<=100; i++)
            {
               for(divisor= 1 ; divisor<=i ; divisor++)
                {
                    if(i % divisor == 0)
                    {
                        numerodivisores += 1;

                    }
}
               if (numerodivisores<=2)
                    {
                    Console.WriteLine(i);
    }
                numerodivisores = 0;


}
}
}
}



