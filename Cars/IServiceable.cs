using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal interface IServiceable
    {
        public void AddDistance(int newDistance);
        public void AddDistance(double newDistance);
        public abstract bool IsReadyToService();
    }
}
