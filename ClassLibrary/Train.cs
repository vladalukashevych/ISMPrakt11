using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Train : Vehicle
    {
        protected int WagonsNumber { set; get; }
        protected string TrainType { set; get; }
        public Train(string trainType, int wagonsNumber, double kilometrage)
        {
            TrainType = trainType;
            WagonsNumber = wagonsNumber;
            Odometer = kilometrage;
            VisitedLocalities = new List<string>();
        }

        public override string GetInfo()
        {
            return "Train (" + TrainType + ", " + WagonsNumber.ToString() + " wagons): " + Odometer.ToString() + "km";
        }
    }
}
