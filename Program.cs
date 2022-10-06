using System;

namespace ATV_QuantDiasMensaisComSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
             int Meses = 0;

            Console.WriteLine("Digite aqui um número correspondente a um mês: ");
              Meses = Convert.ToInt16(Console.ReadLine()); 

            switch (Meses)
            {
                case 1:
                    Console.WriteLine(" O mês de Janeiro tem 31 dias ");
                    break;

                case 2:
                    Console.WriteLine(" O mês de Fevereiro tem geralmente 28 dias, mas em anos bissextos possui 29 dias");
                    break;
                
                case 3:
                    Console.WriteLine(" O mês de Março tem 31 dias");
                    break;

                case 4:
                    Console.WriteLine(" O mês de Abril tem 30 dias");
                    break;

                case 5:
                    Console.WriteLine(" O mês de Maio tem 31 dias");
                    break;
                
                case 6:
                    Console.WriteLine(" O mês de Junho tem 30 dias");
                    break;

                case 7:
                    Console.WriteLine(" O mês de Julho tem 31 dias");
                    break;
                
                case 8:
                    Console.WriteLine(" O mês de Agosto tem 31 dias");
                    break;

                case 9:
                    Console.WriteLine(" O mês de Setembro tem 30 dias");
                    break;
                
                case 10:
                    Console.WriteLine(" O mês de Outubro tem 31 dias");
                    break;

                case 11:
                    Console.WriteLine(" O mês de Novembro tem 30 dias");
                    break;

                case 12:
                    Console.WriteLine(" O mês de Dezembro tem 31 dias");
                    break;
                
                default:
                    Console.WriteLine(" Ocorreu algum erro de digitação, por favor corrijio-o!");
                    break;
                    
                    //Muito Bom!
            }
            
            
        }
    }
}
