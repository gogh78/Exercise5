using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 15 элементов,
            //которые выбираются случайным образом из диапазона [0; 50].
            //Определить сумму максимального и минимального элементов массива.
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int min = array[0];
            foreach (int a in array)
            {
                if (a < min)
                    min = a;
            }
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            }
            Console.WriteLine("Минимальное значение = {0}", min);
            Console.WriteLine("Максимальное значение = {0}", max);
            Console.WriteLine("Сумма минимального и максимального значений = {0}", max+min);
            Console.ReadKey();

        }
    }
}