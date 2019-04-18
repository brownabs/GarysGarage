using System;
using System.Collections.Generic;

namespace garysgarage
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
              Create some battery powered vehicles, add them to a Type IElectricPower List
              and then iterate the List to charge their batteries.
            */

            //Adding Battery Powered vehicles : creating Ranger from the Ford Class, creating TeslaLarge and TelsaMini from the Tesla Class
            Ford Ranger = new Ford()
            {
                MainColor = "Green",
                MaximumOccupancy = 2,
                BatteryKWh = 001.01
            };
            Tesla TeslaLarge = new Tesla()
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

            //add them to a Type IElectricPower List

            List<IElectricPowered> electricVehicles = new List<IElectricPowered>();

            electricVehicles.Add(Ranger);
            electricVehicles.Add(TeslaLarge);
            electricVehicles.Add(TelsaMini);

            //iterate the List to charge their batteries.

            electricVehicles.ForEach(gv => gv.ChargeBattery());

            /*
                Create some gas vehicles, add them to a IGasPowered Type List
                and then iterate the List to fill all of their
                fuel tanks.
            */

            //Create some gas vehicles
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

            //add them to a IGasPowered Type List
            //different way to add vehicles to the gasVehicles list
            List<IGasPowered> gasVehicles = new List<IGasPowered>() {
                RamF150, CessnaF150
            };


            //iterate the List to fill all of their fuel tanks

            gasVehicles.ForEach(gv => gv.RefuelGasTank());


            GasStation Shell = new GasStation();
            BatteryStation BatteryPod = new BatteryStation();


            //Gas Station = Refuel is method from the INeedEnergy Interface
            Shell.Refuel(gasVehicles);
            BatteryPod.Refuel(electricVehicles);


            Ranger.Drive();
            Ranger.Turn();
            Ranger.Stop();
            TeslaLarge.Drive();
            TeslaLarge.Turn();
            TeslaLarge.Stop();
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
