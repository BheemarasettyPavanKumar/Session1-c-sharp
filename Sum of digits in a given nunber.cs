using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_digits_in_a_given_number
{
    class Program
    {
        static void Main(string[] args)
        {
			int Number1;
			int sum = 0;
			int rem;

			Console.Write("Enter number1 value = ");
			Number1 = Convert.ToInt32(Console.ReadLine());


			while (Number1 > 0)
			{
				rem = Number1 % 10;
				sum = sum + rem;
				Number1 = Number1 / 10;

			}

			Console.WriteLine("sum of digits in number1 is = " + sum);
		}
    }
}
