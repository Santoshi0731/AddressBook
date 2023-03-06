
class NoDuplicateEntrySamePerson
{
    public string Name { get; set; }
    public string City { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        NoDuplicateEntrySamePerson other = (NoDuplicateEntrySamePerson)obj;
        return Name == other.Name && City == other.City;
    }
    public override int GetHashCode()
    {
        return Name.GetHashCode() ^ City.GetHashCode();
    }
}

class AddressBook
{
    private List<NoDuplicateEntrySamePerson> people = new List<NoDuplicateEntrySamePerson>();

    public void AddPerson(NoDuplicateEntrySamePerson person)
    {
        if (people.Any(p => p.Equals(person)))
        {
            Console.WriteLine($"Duplicate entry found for {person.Name} in {person.City}.");
        }
        else
        {
            people.Add(person);
            Console.WriteLine($"Added {person.Name} to {person.City}.");
        }
    }

    public List<NoDuplicateEntrySamePerson> SearchByName(string name)
    {
        return people.Where(p => p.Name == name).ToList();
    }
}
