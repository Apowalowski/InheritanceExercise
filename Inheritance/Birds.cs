using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Birds : Animal
    {
        public Birds()
        {
           
        }
        public Birds(bool isLiving, int age, string name, int legs, bool hasBeak, bool hasWings, int twoLegs, bool flight)
        {
            IsLiving = isLiving;
            Age = age;
            Name = name;
            Legs = legs;
            HasBeak = hasBeak;
            HasWings = hasWings;
            TwoLegs = twoLegs;
            Flight = flight;



        }
        public bool HasBeak { get; set; }
        public bool HasWings { get; set; }
        public int TwoLegs { get; set; }
        public bool Flight { get; set; }

      
    }
}
