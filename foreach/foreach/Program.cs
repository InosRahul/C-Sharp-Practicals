using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] a = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            int[] b = new int[10];
            for (int j = 0; j < 10; j++) {
                b[j] = Convert.ToInt16(Console.ReadLine());
            }
                foreach (int x in b)
                {
                    Console.WriteLine("{0}", x);
                }
            //Console.ReadKey();
            foreach(int i in a){
                Console.WriteLine("{0}", i);
                
            }
            Console.ReadKey();
        }
    }
}
