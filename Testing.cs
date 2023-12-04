using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmInterface
{
    public class Testing
    {

        public static void PopulateBarnTest(ItemContainer rootContainer)
        {
            var barn = new ItemContainer("Barn", 5000.00m, 100, 450, 250.0, 250.0, 15.0);
            rootContainer.AddItem(barn);

            var livestockArea = new ItemContainer("Livestock-Area", 1000.00m, 250, 450, 100, 100, 0);
            barn.AddItem(livestockArea);

            var cow = new Item("Cow", 150.00m, 250.00m, 300, 500, 25.0, 25.0, 1.8);
            livestockArea.AddItem(cow);

            var milkstorage = new Item("Milk Storage", 800.00m, 650.00m, 100, 650, 50, 50, 0);
            barn.AddItem(milkstorage);

            var storageBuilding = new ItemContainer("Storage Building", 500.00m, 400, 50, 150, 125, 9.5);
            rootContainer.AddItem(storageBuilding);

            var tractor = new Item("Tractor", 15000.00m, 11300.00m, 425, 75, 25, 75, 0);
            storageBuilding.AddItem(tractor);

            var tiller = new Item("Tiller",1000.00m, 750.00m, 500, 110, 20, 15, 1);
            storageBuilding.AddItem(tiller);

            var commandCenter = new ItemContainer("Command Center", 3500.00m, 50, 50, 150, 250, 0);
            rootContainer.AddItem(commandCenter);

            var drone = new Item("Drone", 1500.00m, 1300.00m, 100, 75, 25, 25, 1);
            commandCenter.AddItem(drone);

            var soyCrop = new Item("Soy Crop", 300.00m, 12000.00m, 400, 400, 375, 175, 0);
            rootContainer.AddItem(soyCrop);
        }
    }
}
