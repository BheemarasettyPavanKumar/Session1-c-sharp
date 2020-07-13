using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centigarde_to_fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            int centigrade;
            double fahrenheit;

            Console.Write("Enter Centrigrade value = ");
            centigrade = Convert.ToInt32(Console.ReadLine());


            fahrenheit = ((centigrade * 1.8) + 32);
            Console.WriteLine("Fahrenheit value is " + fahrenheit);
        }
    }
}
