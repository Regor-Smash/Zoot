using System.Collections.Generic;
using Xamarin.Forms;

namespace Zoot
{
    public static class GeodeviceManager
    {
        static GeodeviceManager()
        {
            //Initialize
            allDevices = new List<Geodevice>();

            AddTestDevices();
        }

        public static List<Geodevice> allDevices { get; private set; }

        private static void AddTestDevices()
        {
            //Create empty/random geodevices for testing purposes
            AddDevice(new Geodevice("Test Device 1", 0.0d));
            AddDevice(new Geodevice("Test Device 2", 0.0d));
            AddDevice(new Geodevice("Test Device 3", 0.0d));
            AddDevice(new Geodevice("Test Device 4", 0.0d));
            AddDevice(new Geodevice("Test Device 5", 0.0d));
            AddDevice(new Geodevice("Test Device 6", 0.0d));
            AddDevice(new Geodevice("Test Device 7", 0.0d));
            AddDevice(new Geodevice("Test Device 8", 0.0d));
            AddDevice(new Geodevice("Test Device 9", 0.0d));
            AddDevice(new Geodevice("Test Device 10", 0.0d));
            AddDevice(new Geodevice("Test Device 11", 0.0d));
            AddDevice(new Geodevice("Test Device 12", 0.0d));
            AddDevice(new Geodevice("Test Device 13", 0.0d));
            AddDevice(new Geodevice("Test Device 14", 0.0d));
            AddDevice(new Geodevice("Test Device 15", 0.0d));
        }

        public static void AddDevice (Geodevice device)
        {
            //Add a device to the list
            allDevices.Add(device);
        }

        public static void RemoveDevice (Geodevice device)
        {
            //Remove a device from the list
            if(allDevices.Contains(device))
            {
                allDevices.Remove(device);
            }
        }

        public static Geodevice FindDevice (string name)
        {
            //Find a device in allDevices given the device's name
            for (int i = 0; i < allDevices.Count; i++)
            {
                if (allDevices[i].deviceName == name)
                {
                    return allDevices[i];
                }
            }

            //Can't find the device
            return null;
        }
    }
}
