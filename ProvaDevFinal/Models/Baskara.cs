using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaDevFinal.Models
{
    class Baskara
    {
        static void Main(string[] args)
        {
            bool convercao;
            double a, b, c;


            convercao = Double.TryParse(Console.ReadLine(), out a);


            convercao = Double.TryParse(Console.ReadLine(), out b);


            convercao = Double.TryParse(Console.ReadLine(), out c);

            Bhaskara1(a, b, c);

        }

        static double Bhaskara1(double a1, double b1, double c1)
        {
            double delta = Math.Pow(b1, 2) - (4 * a1 * c1);
            double x1 = (((b1 * (-1)) + delta) / (2 * a1)); 
            double x2 = (((b1 * (-1)) - delta) / (2 * a1));

            if (delta > 0)
            {
                if (x1 >= x2)
                {
                    return x1;
                }
                else
                {
                    return x2;
                }
            }
            else if( delta == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}