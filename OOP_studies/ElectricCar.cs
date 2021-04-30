using System;

namespace OOP_studies
{
    public class ElectricCar : Car
    {
        private int accumulatorCapacity;

        public ElectricCar() : base()
        {
            accumulatorCapacity = 10000;
        }
        
        public override void Drive()
        {
            Console.WriteLine("I'm rolling smooth");
        }
    }
}