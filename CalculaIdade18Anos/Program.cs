using System;

namespace CalculaIdade18Anos
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Informe sua idade: ");
                recebeAnoNascimento();

            }

        }

        static void recebeAnoNascimento()
        {
       
            int idade = Convert.ToInt32(Console.ReadLine());
            string resposta = calculaIF(idade);
            Console.WriteLine(resposta);
   
        }

        static string CalculaDiferenca(int idade)
        {
            
            if (idade >= 18)
            {
                return "Maior de Idade";
            }
            else
            {
                return "Menor de idade";
            }
        }
        static string calculaIF(int idade)
        {
            if (idade >= 18 && idade < 30)
            {
                return "adulto";
            }                
            else if (idade >= 30 && idade < 50)
            {
                return "meia idade";
            }
                
            else if (idade >= 50 && idade < 70)
            {
                return "idoso";
            }
                
            else if (idade < 18)
            {
                return "juvenil";
            }
                
            else
            {
                return "fazendo hora extra";
            }
             
        }
    }
}
