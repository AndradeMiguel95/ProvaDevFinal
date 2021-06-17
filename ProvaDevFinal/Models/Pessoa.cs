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
            string nome;
            int idade;


            CalculaNumeroPrimo(idade);
        }

        static string CalculaNumeroPrimo(int idade)
        {
            string resultado;
            try
            {
                for (int i = 2; i < idade; i++)
                {
                    int resto = idade % i;
                    if (resto == 0)
                    {
                        resultado = idade + " não é um número primo";
                        i = idade + 1;
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

            return resultado;
            
        }
    }
}