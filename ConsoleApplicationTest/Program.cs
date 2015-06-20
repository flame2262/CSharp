using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");

	        for (int i = 0; i <= 10000; i++)
	        {
		        var car = new Car(i);
	        }

            Console.WriteLine("done");
        }
    }
}
