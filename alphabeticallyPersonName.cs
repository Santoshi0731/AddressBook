using System;


public class Person7
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Phone Number: {PhoneNumber}";
    }
}
