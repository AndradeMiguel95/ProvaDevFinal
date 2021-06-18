using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaDevFinal.Models
{
    public class Baskara
    {
        public void Main(string[] args)
        {
            bool convercao;
            double a, b, c;


            convercao = Double.TryParse(Console.ReadLine(), out a);


            convercao = Double.TryParse(Console.ReadLine(), out b);


            convercao = Double.TryParse(Console.ReadLine(), out c);

            Bhaskara1(a, b, c);

        }

        public double Bhaskara1(double a1, double b1, double c1)
        {
            double delta = (b1 * b1) - (4 * a1 * c1);
            double partA = a1 * 2;
            double partB = b1 * -1;
            double partC = partB + delta;
            double partC2 = partB - delta;
            double x1 = (partC / partA); 
            double x2 = (partC2 / partA);

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