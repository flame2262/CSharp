using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    class Car
    {
	    public int ProductionYear { get; private set; }

	    
        public Car(int productionYear)
        {
	        ProductionYear = ProductionYear;
        }
    
    }
}
