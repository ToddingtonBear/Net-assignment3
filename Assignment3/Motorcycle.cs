using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            DOORS = 0;
            SEATS = 1;
            WHEELS = 2;
        }

        public override void Rev()
        {
            Console.WriteLine("Neeeoooowwww");
        }
    }
}
