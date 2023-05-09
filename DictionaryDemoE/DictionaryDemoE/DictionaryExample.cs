using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemoE
{
    public class DictionaryExample
    {
        public void Dictionarymethod()
        {
           
                Dictionary<string, string> contacts = new Dictionary<string, string>();

                // CREATE: add new elements to the dictionary
                contacts.Add("John Doe", "john.doe@example.com");
                contacts.Add("Jane Doe", "jane.doe@example.com");
                contacts.Add("Bob Smith", "bob.smith@example.com");

                // READ
                Console.WriteLine("Contacts:");
                foreach (KeyValuePair<string, string> contact in contacts)
                {
                    Console.WriteLine($"{contact.Key}: {contact.Value}");
                }

                // UPDATE
                contacts["John Doe"] = "john.doe.updated@example.com";
                Console.WriteLine("\nUpdated John Doe's email address");

                Console.WriteLine("\nContacts:");
                foreach (KeyValuePair<string, string> contact in contacts)
                {
                    Console.WriteLine($"{contact.Key}: {contact.Value}");
                }

                // DELETE
                contacts.Remove("Bob Smith");
                Console.WriteLine("\nRemoved Bob Smith from contacts");

                Console.WriteLine("\nContacts:");
                foreach (KeyValuePair<string, string> contact in contacts)
                {
                    Console.WriteLine($"{contact.Key}: {contact.Value}");
                }
            
        }

    }
}
