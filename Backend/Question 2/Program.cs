using System;

namespace Backend_Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SPLITTING THE CLASSES INTO DIFFERENT CLASSES HELPS READABILITY & FUTURE CODE MANAGEMENT
            //IMPLEMENTING INTERITANCE MAKES THE CODE EASIER TO WORK WITH

            //NEW SHEEP ANIMAL OBJECT
            Animal sheep = new Sheep();
            Console.WriteLine("Sheep says: {0}", sheep.MakeNoise());
            Console.WriteLine("Sheep eating: {0}", sheep.Eat());

            //NEW HORSE ANIMAL OBJECT
            Animal horse = new Horse();
            Console.WriteLine("Horse says: {0}", horse.MakeNoise());
            Console.WriteLine("Horse eating: {0}", horse.Eat());
        }
    }
}
