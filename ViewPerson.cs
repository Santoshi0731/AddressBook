
class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary of people
            Dictionary<string, string> people = new Dictionary<string, string>();
            people.Add("Alice", "New York");
            people.Add("Bob", "Los Angeles");
            people.Add("Charlie", "Chicago");
            people.Add("David", "Chicago");
            people.Add("Emily", "New York");

            // Use lambda expressions to group people by city
            var peopleByCity = people.GroupBy(p => p.Value, p => p.Key);

            // Print the people in each city
            foreach (var cityGroup in peopleByCity)
            {
                Console.WriteLine($"People in {cityGroup.Key}:");
                foreach (var person in cityGroup)
                {
                    Console.WriteLine($"- {person}");
                }
                Console.WriteLine();
            }

            // Use lambda expressions to group people by state
            var peopleByState = people.GroupBy(p => GetState(p.Value), p => p.Key);

            // Print the people in each state
            foreach (var stateGroup in peopleByState)
            {
                Console.WriteLine($"People in {stateGroup.Key}:");
                foreach (var person in stateGroup)
                {
                    Console.WriteLine($"- {person}");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        // Helper method to get the state from a city name
        static string GetState(string city)
        {
            switch (city)
            {
                case "New York":
                    return "New York";
                case "Los Angeles":
                    return "California";
                case "Chicago":
                    return "Illinois";
                default:
                    return "Unknown";
            }
        }
    }
    





