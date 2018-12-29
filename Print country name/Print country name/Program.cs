using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_country_name
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";
            String country = "";
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Country:");
            country = Console.ReadLine();

            Console.WriteLine("Hello " + name + " from " + country);
            Console.ReadKey();
            
        }
    }
}
