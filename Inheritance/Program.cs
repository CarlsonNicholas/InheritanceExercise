using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            //TOP DONE!


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */


            Bird Raven = new Bird();

            Raven.BirdSpecies = "Corvid";
            Raven.Wingspan = "Large - The average is 4.5 feet";
            Raven.MainMobilityMethod = "Flying";
            Raven.ExteriorType = "Feathers";

            Reptile BeardedDragon = new Reptile();

            BeardedDragon.HasTail= true;
            BeardedDragon.BodySize = "Small: The average bearded dragon is 20 inches long";
            BeardedDragon.MainColor = "Green";
            BeardedDragon.Diet = "Mainly Eats Bugs";

            Console.WriteLine($"This is the Inheritance Exercise Completed by Nick Carlson!");
            Console.WriteLine($"");
            Console.WriteLine($"The main class that was created was the Animal class we call the animal class the parent class.");
            Console.WriteLine($"Two child classes inherited the information from the Animal class, the reptile class and the bird class. ");
            Console.WriteLine($"");
            Console.WriteLine($"The First Class we will go over is the Bird class which I used a Raven for.");
            Console.WriteLine($"");
            Console.WriteLine($"The Raven is a species of: {Raven.BirdSpecies}. It's wingspan is {Raven.Wingspan}");
            Console.WriteLine($"The Raven's Main Mobility Method is {Raven.MainMobilityMethod}, and it has {Raven.ExteriorType} on it's exterior.");
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"The Second and final Class we will go over is the Reptile class. I used a Bearded Dragon this time. ");
            Console.WriteLine($"");
            Console.WriteLine($"It is {BeardedDragon.HasTail} that the Bearded Dragon has a tail! The species overall is {BeardedDragon.BodySize}");
            Console.WriteLine($"The main color of the Bearded Dragon is {BeardedDragon.MainColor} and it's diet is: {BeardedDragon.Diet}");
            Console.WriteLine($"");
            Console.WriteLine($"I hope that was creative enough :)");
       


        }
    }
}
