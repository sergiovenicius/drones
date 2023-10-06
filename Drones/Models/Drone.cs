using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Drone : IDrone
    {
        public string Name {get; set; }
        public int MaxWeight {  get; set; }
    }
}
