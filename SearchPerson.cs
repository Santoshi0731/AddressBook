
namespace AddressBookManagementSystem
{
    public class SearchPerson
    {
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
}
