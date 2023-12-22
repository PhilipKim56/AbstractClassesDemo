using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Car
    {
        public Motorcycle() 
        {
        }

        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("A motorcylce uses a handle bar to drive.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("For more information please call YYY-YYY-YYYY.");
        }

    }
}
