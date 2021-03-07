using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayor_y_menor
{
    class Mayormenor
    {
        double numero1;
        double numero2;


        public void selenumero()
        {
            Console.WriteLine("Dame el primer numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame el segundo numero: ");
            numero2 = Convert.ToDouble(Console.ReadLine());




            if(numero1 > numero2)
            {
                Console.WriteLine("El primer numero es el mayor, el cual es {0}", numero1);

            }
            else
                Console.WriteLine("El segundo numero es el mayor, el cual es {0}", numero2);


        }





    }
}
