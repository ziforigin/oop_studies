using System;

namespace OOP_studies
{
    public class Car
    {
        private string maker;
        private string model;

        public Car(string maker, string model)
        {
            this.maker = maker;
            this.model = model;
        }

        public Car()
        {
            
        }
        
        public virtual void Drive()
        {
            Console.WriteLine("I'm driving TRTRTRTRTRTR");
        }
    }
}