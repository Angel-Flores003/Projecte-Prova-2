using System;
using Prova;
using static System.Net.Mime.MediaTypeNames;
//PRE: rep 3 números	
namespace projecteProva2
{
    public class ValidateNum
    {
        public static void main()
        {
            const string Dia = "Introdueix el dia";
            const string Mes = "Introdueix el mes";
            const string Any = "Introdueix el any";
            const string Error = "Erro de programa";
            int dia, mes, any, totalDaysMonth;

            try
            {
                Console.WriteLine(Dia);
                dia = Convert.ToInt32(Console.ReadLine());
                if (dia < 1 || dia > 31)
                {
                    Console.WriteLine(Mes);
                    mes = Convert.ToInt32(Console.ReadLine());
                    if (mes < 1 || mes > 12)
                    {
                        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                        {
                            totalDaysMonth = 31;
                        }
                        else
                            totalDaysMonth = 30;
                    }
                    Console.WriteLine(Any);
                    any = Convert.ToInt32(Console.ReadLine());
                    if ((any % 400 == 0) || ((any % 4 == 0) && (any % 100 != 0)))
                    {
                        totalDaysMonth = 29;
                    }
                    else totalDaysMonth = 28;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}
//POST: retorna si els números (dd, mm, yyyy) estan dins del rang de data corresponent