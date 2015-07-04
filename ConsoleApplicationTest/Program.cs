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

	        for (int i = 0; i <= 100; i++)
	        {
		        var car = new Car(i);
                car.CleanCar();
	        }

            int x = Math.Max(1, 3);
            
            Console.WriteLine("done");
        }
    }
}
