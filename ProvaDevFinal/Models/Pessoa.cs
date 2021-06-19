using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace ProvaDevFinal.Models
{
    public interface IVerificaIdade
    {
        string VerificaIdade(Pessoa p);
    }

    public class Pessoa : IVerificaIdade
    {
        public string Resultado { get; set; }
        public int Idade { get; set; }

        public string VerificaIdade(Pessoa p)
        {
            

            Resultado = p.Idade.ToString();
            try
            {
                for (int i = 2; i < p.Idade; i++)
                {
                    int resto = p.Idade % i;
                    if (resto == 0)
                    {
                        p.Resultado = p.Idade + " não é um número primo";
                        i = p.Idade;
                    }
                    else
                    {
                        p.Resultado = p.Idade + " é um número primo";
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao Verificar nº primo");
                Console.WriteLine(e);
            }
            return p.Resultado;
        }
    }
}