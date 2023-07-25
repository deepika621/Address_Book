using System;
using System.Collections.Generic;


public class Contact
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string Zip { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
}

public class Addressbook
{
    private List<Contact> contacts = new List<Contact>();

    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
    }

    public void PrintContacts()
    {
        foreach (Contact contact in contacts)
        {
            Console.WriteLine("{0} {1}", contact.FirstName, contact.LastName);
            Console.WriteLine("{0}", contact.Address);
            Console.WriteLine("{0}, {1} {2}", contact.City, contact.Zip, contact.PhoneNumber);
            Console.WriteLine("{0}", contact.Email);
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Addressbook addressBook = new Addressbook();

        Contact myContact = new Contact
        {
            FirstName = "Emily",
            LastName = "Johnson",
            Address = "7342 Winding way",
            City = "Arkansas",
            Zip = "12345",
            PhoneNumber = "555-555-1234",
            Email = "johnson@email.com"
        };

        addressBook.AddContact(myContact);

        addressBook.PrintContacts();
    }
}
