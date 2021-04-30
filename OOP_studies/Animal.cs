using System;

namespace OOP_studies
{
    public class Animal
    {
        private int _numberOfLegs;
        

        public Animal(int numberOfLegs)
        {
            _numberOfLegs = numberOfLegs;
        }

        public int CountLegs()
        {
            return _numberOfLegs;
        }

        public virtual void MakeFunnySound()
        {
            Console.Write("THIS IS ANIMAL'S DEFAULT FUNNY SOUND UKACHAKA!\n");
        }
    }
}