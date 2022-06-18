using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Djalma_15_06_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataAtual;
            string mes = null;
            int d, m, a;

            Console.WriteLine("Digite a data(Com Barras)");
            dataAtual = Convert.ToDateTime(Console.ReadLine());

            d = dataAtual.Day;
            m = dataAtual.Month;    
            a = dataAtual.Year;

            switch (m)
            {
                case 1:
                    mes = "Janeiro";
                    break;
                case 2:
                    mes = "Fevereiro";
                    break;
                case 3:
                    mes = "Março";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Maio";
                    break;
                case 6:
                    mes = "Junho";
                    break;
                case 7:
                    mes = "Julho";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Setembro";
                    break;
                case 10:
                    mes = "Outubro";
                    break;
                case 11:
                    mes = "Novembro";
                    break;
                case 12:
                    mes = "DEZEMBRO";
                    break;
            }

            Console.WriteLine(d + " de " + mes + " de " +  a);
            
            if(d == 19 && m == 2 && a == 2004)
            {
                Console.WriteLine("Feliz aniversário Luquinhas (:");
            }
           
            
            
            
            
            Console.ReadKey();

  
   























        }
    }
}
