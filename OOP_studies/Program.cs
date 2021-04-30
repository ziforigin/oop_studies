using System;

namespace OOP_studies
{
    class Program
    {
        static void Main(string[] args)
        {
            // var phone1 = new Phone(3218696, "Nokia", 160);
            // var phone2 = new Phone(3212326, "Samsung", 80);
            // var phone3 = new Phone(3210386, "Sony", 30);


            // Console.Write($"Number:{phone1.GetNumber()}, model:{phone1.GetModel()}, weight:{phone1.GetWeight()}\n");
            // Console.Write($"Number:{phone2.GetNumber()}, model:{phone2.GetModel()}, weight:{phone2.GetWeight()}\n");
            // Console.Write($"Number:{phone3.GetNumber()}, model:{phone3.GetModel()}, weight:{phone3.GetWeight()}\n");
            //
            //phone1.ReceiveCall("Anya");
            // phone2.ReceiveCall("Yasha");
            // phone3.ReceiveCall("Katya");
            //
            // phone1.GetNumber();
            // phone2.GetNumber();
            // phone3.GetNumber();
            //
            // Console.Write($"Number:{phone1.GetNumber()}\n");
            // Console.Write($"Number:{phone2.GetNumber()}\n");
            // Console.Write($"Number:{phone3.GetNumber()}\n");
            
            // phone1.ReceiveCall("Anya", 123456);
            // phone2.ReceiveCall("Yasha", 546780);
            // phone3.ReceiveCall("Katya", 9907654);

            // var sharik = new Dog();
            // sharik.MakeFunnySound();
            // sharik.MakeFunnySound("Anya");
            // Console.Write($"Number:{sharik.MakeFunnySound()}, model:{sharik.MakeFunnySound("Anya")}");
            //
            // var chapa = new Dog();
            // chapa.MakeFunnySound();
            // chapa.MakeFunnySound("Tonya");

            var volkswagenbeatle = new Car("Volkswagen", "Beatle");
            var fordfocus = new Car("Ford", "Focus");

            var teslaModel3 = new ElectricCar();
            
            volkswagenbeatle.Drive();
            teslaModel3.Drive();





        }
    }
}