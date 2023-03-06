

namespace AddressBookManagementSystem
{
    public class MultipalPersonDetail
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string State { get; set; }

        public string PhoneNumber { get; set; }

        public string Zip { get; set; }

        public string Email { get; set; }

        public MultipalPersonDetail(string firstName, string lastName, string address, string city,
            string state, string zip, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;

        }

    }
        class AddressBook1
        {
            List<MultipalPersonDetail> contacts;

            public AddressBook1()
            {
                contacts = new List<MultipalPersonDetail>();
            }

            public void AddContact1(MultipalPersonDetail person) 
            {
                contacts.Add(person);
            }

            public void ListContacts()
            {
                Console.WriteLine("List ofContacts: ");
                Console.WriteLine("------------------");

                foreach(MultipalPersonDetail person in contacts)
                {
                    Console.WriteLine("First Name: {0} ",person.FirstName);
                    Console.WriteLine("Last Name: {0} ", person.LastName);
                    Console.WriteLine("Address: {0} ", person.Address);
                    Console.WriteLine("City: {0} ", person.City);
                    Console.WriteLine("State: {0} ", person.State);
                    Console.WriteLine("Zip: {0} ", person.Zip);
                    Console.WriteLine("PhoneNumber: {0} ", person.PhoneNumber);
                    Console.WriteLine("Email: {0} ", person.Email);
                }
            }
        }
    
}
