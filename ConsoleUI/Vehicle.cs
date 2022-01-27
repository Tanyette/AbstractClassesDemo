using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Make { get; set; } = "crysler";
        public string Model { get; set; } = "300";

        public int Year { get; set; } = 2016;
        // stub Out Method
        public abstract void DriveAbstract();
        
        public virtual void DriveVirtual()
        {
            Console.WriteLine("the car is driving");
        }
        
    }
}
