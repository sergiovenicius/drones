using Drones.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Services
{
    public class DronesInputFile : InputReader
    {
        public DronesInputFile(string input) : base(input) { }

        public IEnumerable<IDrone> ReadDrones()
        {
            if (Input == null) throw new ArgumentNullException("Input content is null");
            if (Input.Any() == false) throw new ArgumentException("Input content is empty");

            string dronesLine = Input.First();

            List<IDrone> drones = new List<IDrone>();

            List<string> droneData = dronesLine.Split(',').ToList();
            for (int a = 0; a < droneData.Count; a += 2)
            {
                Drone drone = new Drone();
                drone.Name = droneData[a].Trim();
                drone.MaxWeight = Int32.Parse(new string(droneData[a + 1].Where(char.IsDigit).ToArray()));
                
                drones.Add(drone);
            }

            return drones;
        }

        public IEnumerable<ILocation> ReadLocations()
        {
            if (Input == null) throw new ArgumentNullException("Input content is null");
            if (Input.Count() <= 1) throw new ArgumentException("Input does not contains locations");

            List<ILocation> locations = new List<ILocation>();

            int line = -1;
            foreach (var locationLine in Input)
            {
                line++;
                if (line == 0) continue;
                
                List<string> locationData = locationLine.Split(',').ToList();
                for (int a = 0; a < locationData.Count; a += 2)
                {
                    Location location = new Location();
                    location.Name = locationData[a].Trim();
                    location.Weight = Int32.Parse(new string(locationData[a + 1].Where(char.IsDigit).ToArray()));

                    locations.Add(location);
                }
            }

            return locations;
        }
    }
}
