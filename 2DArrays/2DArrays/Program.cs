using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int max = 0;
            int[,] array = new int[6,6]
            {
                {1,1,1,0,0,0},
                {0,1,0,0,0,0},
                {1,1,1,0,0,0},
                {0,0,2,4,4,0},
                {0,0,0,2,0,0},
                {0,0,1,2,4,0}
            };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum = array[i, j] + array[i, j + 1] + array[i, j + 2] +
                                   array[i + 1, j + 1] +
                        array[i + 2, j] + array[i + 2, j + 1] + array[i + 2, j + 2];
                    max = Math.Max(max, sum);
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
        
    }
}
