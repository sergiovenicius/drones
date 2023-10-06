using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    public interface ITrip
    {
        int Id { get; }
        IDrone Drone { get; }
        List<ILocation> Locations { get; }
        void AddLocation(ILocation location);
        int GetTotalWeight();
        bool AcceptsNewLocation(ILocation location);
        bool HasLocations();
    }
}
