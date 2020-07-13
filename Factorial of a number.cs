using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
			int Number1;
			int i;
			int factorial = 1;

			Console.Write("Enter number1 value = ");
			Number1 = Convert.ToInt32(Console.ReadLine());


			for (i = 1; i <= Number1; i++)
			{
				factorial = factorial * i;

			}

			Console.WriteLine("Factorial of number1 is = " + factorial);
		}
    }
}
