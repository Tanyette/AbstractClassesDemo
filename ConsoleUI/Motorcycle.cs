using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($"the motor cycle said vroom vroom");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("I drove the MotorCycle Virtually"); 
        }
    }

}
