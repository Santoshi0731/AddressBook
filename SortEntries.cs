
namespace AddressBookManagementSystem
{
    class SortEntries
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public SortEntries(string name, string city, string state, string zip)
        {
            Name = name;
            City = city;
            State = state;
            Zip = zip;
        }

        // Override the ToString method to print the person's details
        public override string ToString()
        {
            return $"{Name}, {City}, {State}, {Zip}";

        }
    }
}
