﻿using System;

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
            Birds Penguin = new Birds()
            {
                IsLiving = true,
                Age = 4,
                Name = "Penguin",
                Legs = 2,
                HasBeak = true,
                HasWings = true,
                TwoLegs = 2,
                Flight = true,
            };

            Reptiles Lizard = new Reptiles()
            {
                IsLiving = true,
                Age = 2,
                Name = "Lizard",
                Legs = 4,
                IsColdBlooded = true,
                EatsBugs = true,
                HasScales = "scales",
                Environment = "forest",
             };

            Console.WriteLine(Penguin.Age);
            Console.WriteLine(Lizard.Age);




        }
        
        }
    }

        /*Create an object of your Reptile class
         *  give values to your members using the object of your Bird class
         *  
         * Creatively display the class member values 
         */
    
    

