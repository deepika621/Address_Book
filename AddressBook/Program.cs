using System;
using System.Collections;
using System.Collections.Generic;

namespace AddressBook
{


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

        // 2.Ability to add new Contact to address book

        // Create a new dictionary to store contacts
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        // Add some initial contacts
        contacts.Add("John Doe", "555-1234");
        contacts.Add("Jane Smith", "555-5678");

        // Ask the user to enter a new contact name and phone number
        Console.Write("Enter a new contact name: ");
        string name = Console.ReadLine();
        Console.Write("Enter a phone number: ");
        string phone = Console.ReadLine();

        // Add the new contact to the dictionary
        contacts.Add(name, phone);

        // Display the updated address book
        Console.WriteLine("Address Book:");
        foreach (KeyValuePair<string, string> contact in contacts)
        {
            Console.WriteLine("{0}: {1}", contact.Key, contact.Value);
        }

            // 3.Ability to edit exixting contact person using their name

            // Display the initial address book
            Console.WriteLine("Initial Address Book:");
            foreach (KeyValuePair<string, string> contact in contacts)
            {
                Console.WriteLine("{0}: {1}", contact.Key, contact.Value);
            }

            // Ask the user which contact to edit
            Console.Write("Enter the name of the contact to edit: ");
            name = Console.ReadLine();

            // Check if the contact exists
            if (contacts.ContainsKey(name))
            {
                // Ask the user to enter the new phone number
                Console.Write("Enter the new phone number: ");
                phone = Console.ReadLine();

                // Update the contact's phone number
                contacts[name] = phone;

                // Display the updated address book
                Console.WriteLine("Updated Address Book:");
                foreach (KeyValuePair<string, string> contact in contacts)
                {
                    Console.WriteLine("{0}: {1}", contact.Key, contact.Value);
                }
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }

            Console.ReadKey();
    }
}
}
