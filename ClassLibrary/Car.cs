using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Car : Vehicle
    {
        protected string Manufacturer { set; get; }
        protected string Color { set; get; }

        public Car(string manufacturer, string color, double kilometrage)
        {
            Manufacturer = manufacturer;
            Color = color;
            Odometer = kilometrage;
            VisitedLocalities = new List<string>();
        }

        public override string GetInfo()
        {
            return "Car (" + Manufacturer + ", " + Color + "): " + Odometer.ToString() + "km";
        }
    }
}
