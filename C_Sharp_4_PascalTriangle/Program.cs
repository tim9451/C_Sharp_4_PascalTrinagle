﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            #region УсловияЗадачи
            // * Задание 2
            // Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
            // 
            // При N = 9. Треугольник выглядит следующим образом:
            //                                 1
            //                             1       1
            //                         1       2       1
            //                     1       3       3       1
            //                 1       4       6       4       1
            //             1       5      10      10       5       1
            //         1       6      15      20      15       6       1
            //     1       7      21      35      35       21      7       1
            //                                                              
            //                                                              
            // Простое решение:                                                             
            // 1
            // 1       1
            // 1       2       1
            // 1       3       3       1
            // 1       4       6       4       1
            // 1       5      10      10       5       1
            // 1       6      15      20      15       6       1
            // 1       7      21      35      35       21      7       1
            // 
            // Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля
            #endregion

            Console.Write("Введите количество строк (не более 25): ");
            int n = int.Parse(Console.ReadLine());

            int[][] PascalTrinagle = new int[n][];
            // первая строка
            PascalTrinagle[0] = new int[] { 1 };

            for (int i = 1; i < PascalTrinagle.Length; i++)
            {
                PascalTrinagle[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        PascalTrinagle[i][j] = 1;
                    else
                    {
                        PascalTrinagle[i][j] = PascalTrinagle[i - 1][j - 1] + PascalTrinagle[i - 1][j];
                    }
                }
            }

            for (int i = 0; i < PascalTrinagle.Length; i++)
            {
                for (int j = 0; j < PascalTrinagle[i].Length; j++)
                {
                    Console.Write("{0,-3} ", PascalTrinagle[i][j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
