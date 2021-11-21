using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя целочисленное значение N.
            //Сформировать двумерный массив размера NxN.
            //Заполнить массив числами, вводимыми с клавиатуры.
            //Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
            //Магическим квадратом называется матрица, сумма элементов которой в каждой строке,
            //в каждом столбце и по каждой диагонали одинакова.
            Console.WriteLine("Введите размер массива NxN");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] t = new int[n, n];
            int ms = ((1 + n * n) * n / 2);
            Console.WriteLine("Введите по порядку значения ячеек массива");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    t[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,4}", t[i, j]);
                    s += t[i, j];
                }
                Console.Write("{0, 8}", s);
                Console.WriteLine();
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                int s = 0;
                for (int j = 0; j < n; j++)
                {
                    s += t[i, j];
                    bool f;
                    if (s != ms)
                    {
                        f = false;
                    }
                    else
                    {
                        f = true;
                    }
                    if (f == false)
                    {
                        Console.WriteLine("квадрат не магический");
                    }
                    else
                    {
                        Console.WriteLine("квадрат магический");
                    }
                }
                
                Console.WriteLine();
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}
