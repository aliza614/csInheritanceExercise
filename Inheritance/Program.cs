using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal DONE
            // give this class 4 members that all Animals have in common


            // Create a class Bird DONE
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var bird=new Bird();
            bird.canSwim=true;
            bird.wingspan = 12;
            bird.height = 5;
            bird.name = "goose";
            bird.maxSpeed = 12;
            bird.lbs = 5;
            bird.maxAltitude = 100;
            bird.numberOfLegs = 2;

            Console.WriteLine(
                $"bird.canSwim = {bird.canSwim}, "+
                $"bird.wingspan = {bird.wingspan}, " +
                $"bird.height = {bird.height}, " +
                $"bird.name = {bird.name}, " +
                $"bird.maxSpeed = {bird.maxSpeed}, " +
                $"bird.lbs = {bird.lbs}, " +
                $"bird.maxAltitude = {bird.maxAltitude}, and " +
                $"bird.numberOfLegs = {bird.numberOfLegs}");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var frog = new Reptile();
            frog.height = 1;
            frog.doesHop = true;
            frog.lbs = 2;
            frog.internalTemp = 70;
            frog.numberOfLegs = 4;
            frog.name = "frog";
            frog.canSwim = true;
            frog.inHibernation = false;

            Console.WriteLine($"frog.height = 	{frog.height}, " +
                $"frog.doesHop =  {frog.doesHop}, " +
                $"frog.lbs =  {frog.lbs}, " +
                $"frog.internalTemp =     {frog.internalTemp}, " +
                $"frog.numberOfLegs = {frog.numberOfLegs}, " +
                $"frog.name =     {frog.name}, " +
                $"frog.canSwim =  {frog.canSwim}, and" +
                $"frog.inHibernation =    {frog.inHibernation}");
        }
    }
}
