using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Vehicle
    {
        protected int doors = 4;
        protected int seats = 5;
        protected int wheels = 4;

        public int DOORS
        {
            get { return doors; }
            set { doors = value; }
        }
        public int SEATS
        {
            get { return seats; }
            set { seats = value; }
        }
        public int WHEELS
        {
            get { return wheels; }
            set { wheels = value; }
        }

        public Vehicle() { Console.WriteLine("Vehicle created"); }

        public virtual void Specs()
        {
            Console.WriteLine(doors + " seats");
            Console.WriteLine(seats + " seats");
            Console.WriteLine(wheels + " wheels");
        }

        public virtual void Rev()
        {
            Console.WriteLine("rumble");
        }
    }
}
