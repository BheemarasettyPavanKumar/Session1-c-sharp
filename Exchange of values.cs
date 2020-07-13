using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_of_values
{
    class Program
    {
        static void Main(string[] args)
        {
			int Number1;
			int Number2;
			int temp;

			Console.Write("Enter number1 value = ");
			Number1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter number2 value = ");
			Number2 = Convert.ToInt32(Console.ReadLine());

			temp = Number1;
			Number1 = Number2;
			Number2 = temp;

			Console.WriteLine("After Excahnging = ");
			Console.WriteLine(" number1 value = " + Number1);
			Console.WriteLine(" number2 value = " + Number2);
		}
    }
}
