using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    class Slot
    {
        public string name { get; set; }

        public string category;

        public Slot(string name)
        {
            this.name = name;

        }
    }
}
