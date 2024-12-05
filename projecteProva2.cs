using System;
using System.Collections.Generic;
using Prova;
using static System.Net.Mime.MediaTypeNames;
//PRE: rep 3 números	
namespace projecteProva2
{
    public class ValidateNum
    {
        public static void InsertNum(int[] arr)
        {
            const string Prime = "Introdueix 20 números enetrs";
            
            for (int i = 0; i < arr.Length; i++)
            { 
                Console.WriteLine(Prime);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static int ValidateNumArr(int[] arr, int first, int last, int key)
        {
            if (last >= first)
            {
                int mid = first + (last - first) / 2;
                if (arr[mid] == key)
                {
                    return mid;
                }
                if (arr[mid] > key)
                {
                    return ValidateNumArr(arr, first, mid - 1, key);//cerca en el subarray esquerre
                }
                else
                {
                    return ValidateNumArr(arr, mid + 1, last, key);//cerca en el subarray dret
                }
            }
            return -1;
        }
        public static void main()
        {
            
            const string Mes = "Introdueix el mes";
            const string Any = "Introdueix el any";
            const string Num = "Introdueix el número que vols verificas si està a l'array";
            const string Error = "Erro de programa";
            int first = 0, last = 19, key;
            int[] arr = new int [20];

            try
            {
                InsertNum(arr);
                Console.WriteLine(Num);
                key = Convert.ToInt32(Console.ReadLine());
                key = ValidateNumArr(arr, first, last, key);

            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}
//POST: retorna si els números (dd, mm, yyyy) estan dins del rang de data corresponent