using System;

namespace AddressBookManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("-------------------------------UC1---------------------------");

            //List<Contact> contacts = new List<Contact>();

            //Contact contact1 = new Contact("Rohan", "Shrma", "123 Main St", "Anyown", "State", "12345", "555-555-1212", "jane.Rohan@email.com");
            //Contact contact2 = new Contact("Rahul", "Modi", "456 Main St", "Anyown", "State", "67890", "555-555-1212", "jane.Rahul@email.com");

            //contacts.Add(contact1);
            //contacts.Add(contact2);

            //foreach (Contact contact3 in contacts)
            //{
            //    Console.WriteLine(contact3);
            //}


            //Console.WriteLine("-------------------------------UC2---------------------------");

            //Console.WriteLine("Added New Contact........"); 

            //AddressBook addressBook = new AddressBook();

            //Console.WriteLine("Enter details for the contact person:");
            //Console.WriteLine("First Name: ");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Last Name: ");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Address: ");
            //string address = Console.ReadLine();
            //Console.WriteLine("City: ");
            //string city = Console.ReadLine();
            //Console.WriteLine("State: ");
            //string state = Console.ReadLine();
            //Console.WriteLine("Phone Number: ");
            //string phoneNumber = Console.ReadLine();
            //Console.WriteLine("Zip: ");
            //string zip = Console.ReadLine();
            //Console.WriteLine("Email: ");
            //string email = Console.ReadLine();


            //ContactPerson contact = new ContactPerson
            //{
            //    FirstName = firstName,
            //    LastName = lastName,
            //    Address = address,
            //    City = city,
            //    State = state,
            //    Zip = zip,
            //    Email = email,
            //    PhoneNumber = phoneNumber,

            //};

            //addressBook.AddContact(contact);

            //Console.WriteLine("Contact added successfully!");


            //Console.WriteLine("-------------------------------UC3---------------------------");

            //Person person = new Person
            //{
            //    FirstName = "John",
            //    LastName = "Doe",
            //    Age = 30
            //};

            //Console.WriteLine("Current person details:");
            //Console.WriteLine("First Name: " + person.FirstName);
            //Console.WriteLine("Last Name: " + person.LastName);
            //Console.WriteLine("Age: " + person.Age);

            //Console.WriteLine("Enter the new first name:");
            //person.FirstName = Console.ReadLine();
            //Console.WriteLine("Enter the new last name:");
            //person.LastName = Console.ReadLine();
            //Console.WriteLine("Enter the new age:");
            //person.Age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Updated person details:");
            //Console.WriteLine("First Name: " + person.FirstName);
            //Console.WriteLine("Last Name: " + person.LastName);
            //Console.WriteLine("Age: " + person.Age);

            //Console.ReadLine();

            //Console.WriteLine("-------------------------------UC4---------------------------");

            //AddressBook addressBook1= new AddressBook();

            //addressBook1.AddPerson("Rahul", "2345-5661-4567");
            //addressBook1.AddPerson("Rohan", "4567-8980-6543");
            //addressBook1.DeletePerson("Rahul");
            //addressBook1.DisplayBook();

            //Console.WriteLine("-------------------------------UC5---------------------------");

            //AddressBook1 addressBook = new AddressBook1();

            //Console.WriteLine("First Name: ");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Last Name: ");
            //string lastName = Console.ReadLine();
            //Console.WriteLine("Address: ");
            //string address = Console.ReadLine();
            //Console.WriteLine("City: ");
            //string city = Console.ReadLine();
            //Console.WriteLine("State: ");
            //string state = Console.ReadLine();
            //Console.WriteLine("Phone Number: ");
            //string phoneNumber = Console.ReadLine();
            //Console.WriteLine("Zip: ");
            //string zip = Console.ReadLine();
            //Console.WriteLine("Email: ");
            //string email = Console.ReadLine();

            //Person1 person1 = new Person1(firstName,lastName,address,city,state,zip,phoneNumber,email);
            //addressBook.AddContact1(person1);

            //Console.WriteLine("Enter details for the second person:");
            //Console.WriteLine("First Name: ");
            //firstName = Console.ReadLine();
            //Console.WriteLine("Last Name: ");
            //lastName = Console.ReadLine();
            //Console.WriteLine("Address: ");
            //address = Console.ReadLine();
            //Console.WriteLine("City: ");
            //city = Console.ReadLine();
            //Console.WriteLine("State: ");
            //state = Console.ReadLine();
            //Console.WriteLine("Phone Number: ");
            //phoneNumber = Console.ReadLine();
            //Console.WriteLine("Zip: ");
            //zip = Console.ReadLine();
            //Console.WriteLine("Email: ");
            //email = Console.ReadLine();

            //Person1 person2 = new Person1(firstName, lastName, address, city, state, zip, phoneNumber, email);
            //addressBook.AddContact1(person2);


            //addressBook.ListContacts();


            //Console.WriteLine();

            //Console.WriteLine("-------------------------------UC7---------------------------");

            //AddressBook addressBook = new AddressBook();

            //addressBook.AddPerson(new NoDuplicateEntrySamePerson { Name = "Alice", City = "New York" });
            //addressBook.AddPerson(new NoDuplicateEntrySamePerson { Name = "Bob", City = "Los Angeles" });
            //addressBook.AddPerson(new NoDuplicateEntrySamePerson { Name = "Charlie", City = "Chicago" });
            //addressBook.AddPerson(new NoDuplicateEntrySamePerson { Name = "Alice", City = "New York" });

            //List<NoDuplicateEntrySamePerson> results = addressBook.SearchByName("Alice");

            //Console.WriteLine($"Search results for Alice:");
            //foreach (var person in results)
            //{
            //    Console.WriteLine($"- {person.Name} ({person.City})");
            //}

            //Console.ReadLine();
            //Console.WriteLine("-------------------------------UC8---------------------------");

            // List<Dictionary<string, string>> addressBooks = new List<Dictionary<string, string>>();

            // Add some people to the address books
            // Dictionary<string, string> addressBook1 = new Dictionary<string, string>();
            // addressBook1.Add("Alice", "New York");
            // addressBook1.Add("Bob", "Los Angeles");
            // addressBook1.Add("Charlie", "Chicago");
            // addressBooks.Add(addressBook1);

            // Dictionary<string, string> addressBook2 = new Dictionary<string, string>();
            // addressBook2.Add("David", "Chicago");
            // addressBook2.Add("Emily", "New York");
            // addressBook2.Add("Frank", "New York");
            // addressBooks.Add(addressBook2);

            // Search for people by city

            //string city = "New York";
            // var peopleInCity = addressBooks.SelectMany(ab => ab.Where(p => p.Value == city)).Select(p => p.Key);

            // Print the search results
            // Console.WriteLine($"People in {city}:");
            // foreach (var person in peopleInCity)
            // {
            //     Console.WriteLine($"- {person}");
            // }
            // Console.WriteLine();

            //// Search for people by state
            //string state = "Illinois";
            //var peopleInState = addressBooks.SelectMany(ab => ab.Where(p => GetState(p.Value) == state)).Select(p => p.Key);

            //// Print the search results
            //Console.WriteLine($"People in {state}:");
            //foreach (var person in peopleInState)
            //{
            //    Console.WriteLine($"- {person}");
            //}
            //Console.WriteLine();

            //Console.ReadLine();


            //Console.WriteLine("-------------------------------UC10---------------------------");
            //List<ContactPerson> contactList = new List<ContactPerson>();

            ////Group the contacts by city and count the number of contacts in each group
            //var contactCountByCity = contactList.GroupBy(c => c.City)
            //                                    .Select(g => new { City = g.Key, Count = g.Count() })
            //                                    .ToList();

            ////Group the contacts by state and count the number of contacts in each group
            //var contactCountByState = contactList.GroupBy(c => c.State)
            //                                     .Select(g => new { State = g.Key, Count = g.Count() })
            //                                     .ToList();

            ////Print the results
            //Console.WriteLine("Contact count by city:");
            //foreach (var contact in contactCountByCity)
            //{
            //    Console.WriteLine($"{contact.City}: {contact.Count}");
            //}
            //Console.WriteLine("\nContact count by state:");
            //foreach (var contact in contactCountByState)
            //{
            //    Console.WriteLine($"{contact.State}: {contact.Count}");
            //    //}

            //Console.WriteLine("-------------------------------UC11---------------------------");

            //List<alphabeticallyPersonName> addressBook = new List<alphabeticallyPersonName>();


            //addressBook.Add(new alphabeticallyPersonName { Name = "John Smith", PhoneNumber = "555-1234" });
            //addressBook.Add(new alphabeticallyPersonName { Name = "Jane Doe", PhoneNumber = "555-5678" });
            //addressBook.Add(new alphabeticallyPersonName { Name = "Bob Johnson", PhoneNumber = "555-9012" });


            //addressBook.Sort((person1, person2) => person1.Name.CompareTo(person2.Name));


            //foreach (alphabeticallyPersonName person in addressBook)
            //{
            //    Console.WriteLine(person);
            //}

            //Console.ReadLine();


            //    Console.WriteLine("-------------------------------UC12---------------------------");

            //List<SortEntries> addressBook = new List<SortEntries>
            //{
            //    new SortEntries("John Doe", "New York", "NY", "10001"),
            //    new SortEntries("Alice Smith", "Los Angeles", "CA", "90001"),
            //    new SortEntries("Bob Johnson", "Chicago", "IL", "60601")
            //};


            //addressBook.Sort((person1, person2) => person1.City.CompareTo(person2.City));


            //Console.WriteLine("Sorted Address Book by City:");
            //foreach (SortEntries person in addressBook)
            //{
            //    Console.WriteLine(person);
            //}
            //addressBook.Sort((person1, person2) => person1.State.CompareTo(person2.State));


            //Console.WriteLine("\nSorted Address Book by State:");
            //foreach (SortEntries person in addressBook)
            //{
            //    Console.WriteLine(person);
            //}


            //addressBook.Sort((person1, person2) => person1.Zip.CompareTo(person2.Zip));

            //// Print the sorted list by Zip
            //Console.WriteLine("\nSorted Address Book by Zip:");
            //foreach (SortEntries person in addressBook)
            //{
            //    Console.WriteLine(person);
            //}

            //Console.WriteLine("-------------------------------UC12---------------------------");

        }

    }
}