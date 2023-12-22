using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "0";
        public string Make { get; set; } = "N/A";
        public string Model { get; set; } = "N/A";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual() 
        {
            Console.WriteLine("More information please call: XXX-XXX-XXXX");
        }

    }
}
