using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
			int Number1;
			int Number2;
			int Number3;

			Console.Write("Enter number1 value = ");
			Number1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter number2 value = ");
			Number2 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter number3 value = ");
			Number3 = Convert.ToInt32(Console.ReadLine());

			if (Number1 > Number2 && Number1 > Number3)
			{
				Console.WriteLine("Largest number is " + Number1);
			}
			else if (Number2 > Number3 && Number2 > Number1)
			{
				Console.WriteLine("Largest number is " + Number2);
			}
			else
			{
				Console.WriteLine("Largest number is " + Number3);
			}
		}
    }
}
