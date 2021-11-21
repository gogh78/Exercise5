using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 7 элементов.
            //Заполнить массив числами, вводимыми с клавиатуры,
            //определить среднее арифметическое элементов.
            Console.WriteLine("Введите 7 чисел массива");
            const int n = 7;
            int[] array = new int[n];
            float s = 0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                s += array[i];
                Console.Write("{0,4}", array[i]);
            }
                         
            Console.WriteLine();
            Console.WriteLine("Cреднее арифметическое = {0}", s / n);
            Console.ReadKey();
        }
    }
}
