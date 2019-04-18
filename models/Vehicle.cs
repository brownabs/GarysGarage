using System;

namespace garysgarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Drive!");
        }
        public virtual void Turn()
        {
            Console.WriteLine("Turn!");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Stop!");
        }
    }
}