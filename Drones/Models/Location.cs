using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Location : ILocation
    {
        public string Name { get; set; }

        public int Weight { get; set; }
    }
}
