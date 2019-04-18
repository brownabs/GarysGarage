using System;

namespace garysgarage
{

    public class Ram : Vehicle, IGasPowered
    {  // Gas powered truck
        public double FuelCapacity { get; set; }
        public void RefuelGasTank()
        {
            Console.WriteLine("Getting Gas");
        }

        public override void Drive()
        {
            Console.WriteLine($" The {MainColor} Ram rumbles by!");
        }
        public override void Turn()
        {
            Console.WriteLine($" The {MainColor} Ram runs over the curb turning right!");
        }


    }

}