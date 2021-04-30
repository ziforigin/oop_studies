using System;
using System.Buffers.Text;

namespace OOP_studies
{
    public class Hedgehog : Animal
    {
        public Hedgehog() : base(4)
        {}

        public override void MakeFunnySound()
        {
            Console.Write("This is how hedgehog sounds: sniff sniff sniff\n");
        }
    }
}