# Drone Delivery Service
A squad of drones is tasked with delivering packages for a major online reseller in a world 
where time and distance do not matter. Each drone can carry a specific weight and can make 
multiple deliveries before returning to home base to pick up additional loads; however, the goal 
is to make the fewest number of trips as each time the drone returns to home base, it is 
extremely costly to refuel and reload the drone. 
The purpose of the written software is to accept input which will include the name of each 
drone and the maximum weight it can carry, along with a series of locations and the total weight 
needed to be delivered to that specific location. The software should highlight the most efficient 
deliveries for each drone to make on each trip. 
Assume that time and distance to each drop off location do not matter, and that the size of 
each package is also irrelevant. It is also assumed that the cost to refuel and restock each 
drone is a constant and does not vary between drones. The maximum number of drones in a 
squad is 100, and there is no maximum number of deliveries which are required. 

## Solution Provided 

Please supply an input data file. The client should be able to run the project and display results. 

## Given Input 

Line 1: [Drone #1 Name], [#1 Maximum Weight], [Drone #2 Name], [#2 Maximum Weight], etc. 
Line 2: [Location #1 Name], [Location #1 Package Weight] 
Line 3: [Location #2 Name], [Location #2 Package Weight] 
Line 4: [Location #3 Name], [Location #3 Package Weight]
Etc. 

## Expected Output 

[Drone #1 Name]
Trip #1 
[Location #2 Name], [Location #3 Name]
Trip #2
[Location #1 Name] 

[Drone #2 Name]
Trip #1

# Solution

This solution was built using C# and .net 7, you can run using Visual Studio 2022.
The Input.txt file comes along with the solution in it's root folder, and it's copied to the output directory.
The implementation considered using POO using classes as Drone, Location and Trip (along with its interfaces).
The trip calculation considers getting the drones that can load the maximum weight and also try to deliver the packages with less weight first.
