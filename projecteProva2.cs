using System;
using Prova;

namespace projecteProva2
{
    public class MyProject
    {
        public static void main()
        {
            const string MSG = "La llista de valors ordeana és: ";
            const string Error = "Error de programa ";
            int[] arr = { 10, -4, 6, 4, 8, 13, 2, -4 };
            int num, low = 0, high = 7;
            try
            {
                SecondSort.Order(arr, low, high);
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}