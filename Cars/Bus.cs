using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Bus : Car
    {
        public Bus(string marks, int yearsOfProdaction, int price, int weight, Color colors) :
            base(marks, yearsOfProdaction, price, weight, colors)
        {

        }
        public override bool IsReadyToService()
        {
            if (DistanceOnService > 50_000)
            {
                return true;
            }
            return false;
        }
        public override void Service()
        {
            if (DistanceOnService > 50_000)
            {
                DistanceOnService = 0;
            }
        }
    }
}