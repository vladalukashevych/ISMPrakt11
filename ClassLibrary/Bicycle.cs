using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Bicycle : Vehicle
    {
        protected string Color { set; get; }
        protected double WheelDiameter { set; get; }

        public Bicycle(string color, double wheelDiameter, double kilometrage)
        {
            Color = color;
            WheelDiameter = wheelDiameter;
            Odometer = kilometrage;
            VisitedLocalities = new List<string>();
        }

        public override string GetInfo()
        {
            return "Bicycle (" + Color + ", " + WheelDiameter.ToString() + " cm wheel): " + Odometer.ToString() + "km";
        }
    }
}
