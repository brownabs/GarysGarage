using System;

namespace garysgarage
{

public class Cessna : Vehicle, IGasPowered {  // Propellor light aircraft
    public double FuelCapacity { get; set; }
        public void RefuelGasTank () {
        Console.WriteLine("Getting Gas");
     }

     public override void Drive () {
        Console.WriteLine($" The {MainColor} Cessna Zips by!");
    }

    public override void Stop () {
        Console.WriteLine($" The {MainColor} Cessna crashes into the runway coming to a halt!");
    }
}

}