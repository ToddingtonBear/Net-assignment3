using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(): base()
        {
            DOORS = 0;
            SEATS = 1;
            WHEELS = 2;
            Console.WriteLine("It is a motorcycle");
        }

        public override void Rev()
        {
            Console.WriteLine("Neeeoooowwww");
        }
    }
}
