using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Device
{
    internal class Device
    {
        public string Name { get; set; }
        public string Maker { get; set; }

        public double Cost { get; set; }

        public Device() {}
        public Device(string name, string maker, double cost)
        {
            Name = name;
            Maker = maker;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nMaker: {Maker}\nCost: {Cost}";
        }
    }
}
