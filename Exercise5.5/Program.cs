using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя целочисленное значение N.
            //Сформировать двумерный массив размера NxN следующего вида:
            Console.WriteLine("Введите размер массива NxN");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[n, n];
            int x;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    x = ((i + j) % 2 != 0) ? 0 : 1;
                    Console.Write("{0,4}", x);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
