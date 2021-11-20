using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                int m = n;
                int[,] t = new int[n, m];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        t[i, j] = 1 - (i + j) % 2;
                        Console.Write("{0} ", t[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Ошибка! Допустимы только положительные значения.");
            Console.ReadKey();
        }
    }
}
