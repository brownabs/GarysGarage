using System;
using System.Collections.Generic;

namespace garysgarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero Ford = new Zero()
            {
                MainColor = "Green",
                MaximumOccupancy = 2,
                BatteryKWh = 001.01
            };
            Zero Mustang = new Zero()
            {
                MainColor = "White",
                MaximumOccupancy = 4,
                BatteryKWh = 12312.123
            };
            Tesla TelsaMini = new Tesla()
            {
                MainColor = "Red",
                MaximumOccupancy = 2,
                BatteryKWh = 313.12
            };

            List<IElectricPowered> electricVehicles = new List<IElectricPowered>();

            electricVehicles.Add(Ford);
            electricVehicles.Add(Mustang);
            electricVehicles.Add(TelsaMini);

            electricVehicles.ForEach(gv => gv.ChargeBattery());

            /*
                Create some gas vehicles, add them to a List
                and then iterate the List to fill all of their
                fuel tanks.
            */
            Ram RamF150 = new Ram()
            {
                MainColor = "Red",
                MaximumOccupancy = 2,
                FuelCapacity = 22.23
            };
            Cessna CessnaF150 = new Cessna()
            {
                MainColor = "Blue",
                MaximumOccupancy = 2,
                FuelCapacity = 55.23
            };

            //different way to add vehicles to the gasVehicles list
            List<IGasPowered> gasVehicles = new List<IGasPowered>() {
                RamF150, CessnaF150
            };

            gasVehicles.ForEach(gv => gv.RefuelGasTank());


            GasStation NeedsGas = new GasStation();
            BatteryStation NeedsElectricity = new BatteryStation();

            NeedsGas.GoToRefuelStation(gasVehicles);
            NeedsElectricity.GoToRefuelStation(electricVehicles);


            Ford.Drive();
            Ford.Turn();
            Ford.Stop();
            Mustang.Drive();
            Mustang.Turn();
            Mustang.Stop();
            TelsaMini.Drive();
            TelsaMini.Turn();
            TelsaMini.Stop();
            RamF150.Drive();
            RamF150.Turn();
            RamF150.Stop();
            CessnaF150.Drive();
            CessnaF150.Turn();
            CessnaF150.Stop();


        }
    }
}
