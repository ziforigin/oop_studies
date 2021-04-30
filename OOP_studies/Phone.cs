using System;

namespace OOP_studies
{
    public class Phone
    { 
        private int number;
        private string model;
        private int weight;
        

        public Phone(int number, string model, int weight) : this(number, model)
        {
            // this.number = number;
            // this.model = model;
            this.weight = weight;
            
        }
        
        public Phone(int number, string model)
        {
            this.number = number;
            this.model = model;
        }
        
        public Phone() { }

        public int GetNumber()
        {
            return number;
        }
        
        public string GetModel()
        {
            return model;
        }
        
        public int GetWeight()
        {
            return weight;
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"Zvonit {name}");
        }
        
        public void ReceiveCall(string name, int number)
        {
            Console.WriteLine($"Zvonit {name}, number is {number}");
        }
    }
    
}