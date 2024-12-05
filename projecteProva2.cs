using System;
using Prova;

namespace projecteProva2
{
    public class MyProject
    {
        public static void main()
        {
            const string MSG = "introdueix un nnúmero per comprovar si està dins l'array";
            const string NotIn = "El número inroduit no es troba dins l'array";
            const string In = "El núemro es troba dins l'array";
            const string Error = "Error de programa ";
            int[] arr = { 10, -4, 6, 4, 8, 13, 2, -4 };
            int num, first = 0, last = 8;
            try
            {
                Console.WriteLine(MSG);
                num = Convert.ToInt32(Console.ReadLine());
                num = SearchClass.BinarySearch(arr, first, last, num);
                if (num == -1)
                {
                    Console.WriteLine(NotIn);
                }
                else
                {
                    Console.WriteLine(In);
                    Console.WriteLine(num);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}