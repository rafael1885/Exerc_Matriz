﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerc_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int[,] mat = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    string[] values = Console.ReadLine().Split(' ');

                    for (int j = 0; j < n; j++)
                    {
                        mat[i, j] = int.Parse(values[j]);

                    }
                }



            }
    }
}
