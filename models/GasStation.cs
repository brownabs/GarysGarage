using System;
using System.Collections.Generic;

namespace garysgarage
{
    public class GasStation : INeedEnergy<IGasPowered>
    {
        public int Capacity { get; set; }
        public void Refuel(List<IGasPowered> vehicles){
            vehicles.ForEach(v => v.RefuelGasTank());
        }
    }
}