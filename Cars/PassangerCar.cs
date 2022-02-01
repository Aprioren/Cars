using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class PassangerCar : Car
    {
        public PassangerCar(string marks, int yearsOfProdaction, int price, int weight, Color colors):
            base (marks, yearsOfProdaction, price, weight, colors)
        {
            
        }
        public override bool IsReadyToService()
        {
            if (DistanceOnService > 10_000)
            {
                return true;
            }
            return false;
        }
        public override void Service()
        {
            if (DistanceOnService > 10_000)
            {
                DistanceOnService = 0;
            }
        }
    }
}
