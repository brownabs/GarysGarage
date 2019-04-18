using System;

namespace garysgarage
{
    public class Tesla : Vehicle, IElectricPowered
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine("Charging Battery");
        }

        public override void Drive()
        {
            Console.WriteLine($" The {MainColor} Tesla Vrooooooms by!");
        }
        public override void Stop()
        {
            Console.WriteLine($" The {MainColor} Tesla slams on their brakes, stopping!");
        }


    }


}