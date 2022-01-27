using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine($"the car was in drive");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }
    }
}
