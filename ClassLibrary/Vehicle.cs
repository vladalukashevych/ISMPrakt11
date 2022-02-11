using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Vehicle
    {
        protected double Odometer { set; get; }
        protected List<string> VisitedLocalities;
        public void Drive(string destination, double km)
        {
            Odometer += km;
            VisitedLocalities.Add(destination);
        }
        public double GetKilometrage()
        {
            return Odometer;
        }
        public void ResetOdometer()
        {
            Odometer = 0;
        }
        public List<string> GetVisitedLocalities()
        {
            return VisitedLocalities;
        }
        public abstract string GetInfo();
    }
}
