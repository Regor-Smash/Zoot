using System;
namespace Zoot
{
    public class Geodevice
    {
        public Geodevice(string _name, double _loc)
        {
            deviceName = _name;
            location = _loc;
        }

        public string deviceName { get; private set; }
        public double location { get; private set; }
    }
}
