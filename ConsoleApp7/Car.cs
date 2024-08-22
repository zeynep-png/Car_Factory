using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Factory
{
    public class Car
    {
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int NumberOfDoor { get; set; }
        public DateTime ProductionDate { get; private set; }

        public Car()
        {
            ProductionDate = DateTime.Now;
        }
    }

}
