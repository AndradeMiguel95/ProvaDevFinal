using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace ProvaDevFinal.Models
{
    public class Pessoa
    {
        static void Main(string[] args)
        {
            bool nome;
            double idade;

            nome = Double.TryParse(Console.ReadLine(), out idade);

            CalculaNumeroPrimo(idade);
        }

        static string CalculaNumeroPrimo(double idade)
        {
            string resultado;
            try
            {
                for (double i = 2; i < idade; i++)
                {
                    double resto = idade % i;
                    if (resto == 0)
                    {
                        i = idade + 1;
                        resultado = idade + " não é um número primo";
                    }
                    else
                    {
                        resultado = idade + " é um número primo";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao Verificar nº primo");
                Console.WriteLine(e);
            }

            return "";
            
        }
    }
}