using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptiles : Animal
    {
        public Reptiles()
        {

        }
        public Reptiles(bool isLiving, int age, string name, int legs, bool isColdBlooded, bool eatsBugs, string hasScales, string environment)
        {
            IsLiving = isLiving;
            Age = age;
            Name = name;
            Legs = legs;
            IsColdBlooded = isColdBlooded;
            EatsBugs = eatsBugs;
            HasScales = hasScales;
            Environment = environment;
        }
        public bool IsColdBlooded { get; set; }
        public bool EatsBugs { get; set; }
        public string HasScales { get; set; }
        public string Environment { get; set; }
    }
}
