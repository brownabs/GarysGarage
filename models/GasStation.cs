using System;
using System.Collections.Generic;

namespace garysgarage
{
    public class GasStation : INeedEnergy<IGasPowered>
    {
        public int Capacity { get; set; }
        public void GoToRefuelStation(List<IGasPowered> vehicles){
            vehicles.ForEach(v => v.RefuelGasTank());
        }
    }
}