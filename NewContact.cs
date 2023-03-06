
namespace AddressBookManagementSystem
{
    public class NewContact
    {
        public class ContactPerson
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }

            public string State { get; set; }

            public string PhoneNumber { get; set; }

            public string Zip { get; set; }

            public string Email { get; set; }
        }

        public class AddressBook
        {
            public List<ContactPerson> Contacts { get; set; }

            public AddressBook()
            {
                Contacts = new List<ContactPerson>();
            }

            public void AddContact(ContactPerson contact)
            {
                Contacts.Add(contact);
            }

            public void AddContactPerson(ContactPerson contact)
            {
                Contacts.Add(contact);
            }
        }
        

    }
}
