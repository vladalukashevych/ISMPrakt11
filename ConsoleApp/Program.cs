using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] veharr = new Vehicle[4];
            veharr[0] = new Car("Honda", "green", 50000);
            veharr[1] = new Taxi("Toyota", "gray", "FILLA", 123000);
            veharr[2] = new Train("Open-top box", 18, 6300);
            veharr[3] = new Bicycle("aqua", 62, 0);

            foreach (Vehicle vehicle in veharr)
            {
                vehicle.Drive("Katerynivka", 13);
            }

            veharr[0].ResetOdometer();
            veharr[0].Drive("Kyiv", 140);
            Console.WriteLine($"Kilometrage: {veharr[0].GetKilometrage()}");

            veharr[1].Drive("Lviv", 400);
            Console.WriteLine("Visited localities: ");
            veharr[1].GetVisitedLocalities().ForEach(Console.WriteLine);
            
            double totalkm = 0;
            foreach (Vehicle vehicle in veharr)
            {
                Console.WriteLine($"{vehicle.GetInfo()}");
                totalkm += vehicle.GetKilometrage();
            }
            Console.Write($"Total kilometrage: {totalkm}");
        }
    }
}
