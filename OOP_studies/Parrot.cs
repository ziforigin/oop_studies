using System;

namespace OOP_studies
{
    public class Parrot : Animal
    {
        public Parrot() : base(2)
        {}

        public override void MakeFunnySound()
        {
            Console.Write("How parrot talks: squi squi squi fuitwu");
        }
    }
}