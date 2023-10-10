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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var swallow = new Bird("short", true, "short", "short");

            Console.WriteLine($"A swallow is a bird that has a {swallow.WingSpan} wingspan, does it migrate is {swallow.Migratory}, it has a {swallow.Beak}" +
                $" beak, and {swallow.Plumage}  plumage.");



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var snake = new Reptile("short", true, 2, "small to large");

            Console.WriteLine($"A snake is a reptile that has a {snake.Protection} for protection, does it lay eggs is {snake.LaysEggs}, it has {snake.Lungs}" +
                $" lungs, and can be {snake.Size}.");
        }
    }
}
