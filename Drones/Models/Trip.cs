using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public class Trip : ITrip
    {
        public int Id { get; set; }

        public IDrone Drone { get; set; }

        public List<ILocation> Locations { get; } = new List<ILocation>();

        public Trip(IDrone drone) 
        { 
            Drone = drone;
        }

        public void AddLocation(ILocation location)
        {
            Locations.Add(location);
        }

        public int GetTotalWeight()
        {
            if (Locations == null) return 0;
            return Locations.Sum(r => r.Weight);
        }

        public bool AcceptsNewLocation(ILocation location)
        {
            return GetTotalWeight() + location.Weight <= Drone.MaxWeight;
        }

        public bool HasLocations()
        {
            return Locations.Count > 0;
        }

    }
}
