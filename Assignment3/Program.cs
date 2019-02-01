using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //demonstrate functionality
            Vehicle v1 = new Vehicle();
            v1.Specs();
            v1.Rev();
            Motorcycle m1 = new Motorcycle();
            m1.Specs();
            m1.Rev();
            Console.ReadKey();
        }
    }
}
