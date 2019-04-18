    
using System;
using System.Collections.Generic;

namespace garysgarage
{
    public class BatteryStation : INeedEnergy<IElectricPowered>
    {
        public int Capacity { get; set; }
        public void GoToRefuelStation(List<IElectricPowered> vehicles){
            vehicles.ForEach(v => v.ChargeBattery());
        }
    }
}