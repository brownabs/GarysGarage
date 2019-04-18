using System;

namespace garysgarage
{

    public class Zero : Vehicle, IElectricPowered
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            Console.WriteLine("Charging Battery");
        }

        public override void Drive()
        {
            Console.WriteLine($" The {MainColor} Zero zoooooms by!");
        }
        public override void Turn()
        {
            Console.WriteLine($" The {MainColor} Zero slowly and crefully turns right!");
        }


    }

}