using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace star_matrix_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_of_lines;
            Console.WriteLine("Enter number of lines for pattern:");
            number_of_lines = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < number_of_lines; i++) {
                for (int j = 0; j < number_of_lines; j++) {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
