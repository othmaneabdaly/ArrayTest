using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "taha";
            string b = "othmane";
            string c = "aymen";
            string d = "Simo";
            int[] tab = new int[] { 1, 5, 7, 35, 4, 2, 6, 9, 8 };
            tri(tab);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i] + " ");
            }
            Console.WriteLine($"{a} et {b} et {c}");
            Console.ReadKey();
        }
        static void tri(int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
