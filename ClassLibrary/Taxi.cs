using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Taxi : Car
    {
        protected string Corporation { set; get; }

        public Taxi(string manufacturer, string color, double kilometrage, string corporation): base(manufacturer, color, kilometrage)
        {
            Corporation = corporation;
        }

        public override string GetInfo()
        {
            return "Taxi (" + Corporation + ", "+ Manufacturer + ", " + Color + "): " + Odometer.ToString() + "km";
        }
    }
}
