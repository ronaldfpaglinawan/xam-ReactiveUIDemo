using ReactiveUIDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUIDemo.Services
{
    public interface IContactsService
    {
        IEnumerable<Contact> GetAllContacts();
    }

    public class StaticContactsService : IContactsService
    {
        private static List<Contact> _samples = new List<Contact>()
        {
            new Contact {FullName = "Ahmad Mozaffar", Email = "aksoftware@hotmail.com", Phone = "09876543"},
            new Contact {FullName = "Sami Contact", Email = "sami@hotmail.com", Phone = "091234567"},
            new Contact {FullName = "Sarah Conor", Email = "sarah@t3.com", Phone = "12345678"},
            new Contact {FullName = "Jouli Smith", Email = "jouli@hotmail.com", Phone = "45657289"},
            new Contact {FullName = "Ronald Paglinawan", Email = "ronaldpaglinawan@me.com", Phone = "123456789"}
        };

        public IEnumerable<Contact> GetAllContacts()
        {
            return _samples;
        }
    }
}
