using Drones.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Services
{
    public class Calculator
    {
        private readonly List<IDrone> drones;
        private readonly List<ILocation> locations;
        public Calculator()
        {
            drones = new List<IDrone>();
            locations = new List<ILocation>();
        }

        public void AddDrone(IDrone drone)
        {
            if (drones.Count(r => r.Name == drone.Name) == 0)
                drones.Add(drone);
        }
        public void AddLocation(ILocation location)
        {
            if (locations.Count(r => r.Name == location.Name) == 0)
                locations.Add(location);
        }

        public List<ITrip> GenerateTrips()
        {
            if (drones.Count() == 0) return new List<ITrip>();
            if (locations.Count() == 0) { return new List<ITrip>(); }

            List<ITrip> trips = new List<ITrip>();

            //less weights in the beginning
            var remainingLocations = locations.OrderBy(r => r.Weight).ToList();
            //the strongest drones in the beginning
            var orderedDrones = drones.OrderByDescending(r => r.MaxWeight).ToList();

            int currentDronePosition = 0;

            do
            {
                IDrone currentDrone = orderedDrones[currentDronePosition];

                var fitLocations = remainingLocations.Where(r => r.Weight <= currentDrone.MaxWeight).ToList();

                if (fitLocations.Count() > 0)
                {
                    ITrip trip = new Trip(currentDrone);

                    foreach (var location in fitLocations)
                    {
                        if (trip.AcceptsNewLocation(location))
                        {
                            trip.AddLocation(location);
                            //used location is removed from the list
                            remainingLocations.Remove(remainingLocations.First(r => r.Name == location.Name));
                        }
                    }

                    if (trip.HasLocations())
                        trips.Add(trip);
                }

                currentDronePosition++;
                if (currentDronePosition >= orderedDrones.Count)
                    currentDronePosition = 0;

            } while (remainingLocations.Count() > 0);

            return trips;
        }

    }
}
