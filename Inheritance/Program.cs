using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBird = new Bird();
            myBird.WingColor = "pink";
            myBird.CanFLy = true;
            myBird.WillMigrate = true;
            myBird.BeakLenght = 3.7;

            var lizard = new Reptile();
            lizard.CanGrowTail = true;
            lizard.IsColdBlooded = true;
            lizard.IsScaly = true;
            lizard.Habitiat = "swamp";

            var myAnimals = new Animal[] { myBird, lizard };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine($"");
            }
            
            

            /* - DONE - 
             * 
             *Create an object of your Bird class 
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
