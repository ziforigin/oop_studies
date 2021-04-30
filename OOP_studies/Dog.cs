using System;

namespace OOP_studies
{
    public class Dog : Animal

    {
        private string name;
        public Dog() : base(4)
        {}

        public override void MakeFunnySound()
        {
            Console.WriteLine("Bark, bark!");
        }
        
        public void MakeFunnySound(string name)
        {
            Console.WriteLine($"Bark, bark, {name}!");
        }
    }
}