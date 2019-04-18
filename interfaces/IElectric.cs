using System;

namespace garysgarage {
    public interface IElectricPowered {
        double BatteryKWh {get; set;}

        void ChargeBattery ();
    }
}