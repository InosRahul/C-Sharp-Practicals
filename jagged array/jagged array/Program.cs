using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jag_array = new int[][] { new int[] { 1, 2 }, new int[] { 7, 4 }, new int[] { 12, 18 }, new int[] { 6, 4, 2, 0 }, new int[] { 9, 11, 13 } };
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 2; j++) {
                    Console.WriteLine("jag_array[{0}][{1}] = {2}", i, j, jag_array[i][j]);
                }
            }
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("jag_array[3][{0}] = {1}", i, jag_array[3][i]);
            }
            for (int j = 0; j < 3; j++) {
                Console.WriteLine("jag_array[4][{0}] = {1}",j,jag_array[4][j]);
            }
            Console.ReadKey();
        }
    }
}
