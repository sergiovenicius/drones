using Drones.Services;

Calculator optimizer = new Calculator();

DronesInputFile input = new DronesInputFile("Input.txt");
foreach (var drone in input.ReadDrones())
    optimizer.AddDrone(drone);

foreach (var location in input.ReadLocations())
    optimizer.AddLocation(location);

var trips = optimizer.GenerateTrips();

foreach (var drone in trips.Select(r => r.Drone).OrderBy(r => r.Name).Distinct())
{
    Console.WriteLine(Environment.NewLine + drone.Name);
    int tripId = 1;
    foreach (var trip in trips.Where(r => r.Drone.Name == drone.Name))
    {
        Console.WriteLine($"Trip #{tripId++}");
        Console.WriteLine(string.Join(", ", trip.Locations.OrderBy(r => r.Name).Select(r => r.Name)));
    }
}
