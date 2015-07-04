using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        public void CleanCar()
        {
            //Thread.Sleep(30);
            _isCarClean = true;

        }

        public bool IsCarClean()
        {
            return _isCarClean;
        }


        private bool _isCarClean = false;

        private string _name;

    }
}
