using ReactiveUI;
using ReactiveUIDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Text;

namespace ReactiveUIDemo.ViewModels
{
    public class ContactsViewModel : ReactiveObject
    {

        private List<Contact> _samples = new List<Contact>()
        {
            new Contact {FullName = "Ahmad Mozaffar", Email = "aksoftware@hotmail.com", Phone = "09876543"},
            new Contact {FullName = "Sami Contact", Email = "sami@hotmail.com", Phone = "091234567"},
            new Contact {FullName = "Sarah Conor", Email = "sarah@t3.com", Phone = "12345678"},
            new Contact {FullName = "Jouli Smith", Email = "jouli@hotmail.com", Phone = "45657289"},
            new Contact {FullName = "Ronald Paglinawan", Email = "ronaldpaglinawan@me.com", Phone = "123456789"}
        };

        public ContactsViewModel()
        {
            _contacts = new ObservableCollection<Contact>(_samples);

            this.WhenAnyValue(vm => vm.SearchQuery)
                .Throttle(TimeSpan.FromSeconds(1))
                .Subscribe(query =>
                {
                    var filteredContacts = _samples.Where(c => c.FullName.ToLower().Contains(query) || c.Phone.Contains(query) || c.Email.Contains(query)).ToList();

                    Contacts = new ObservableCollection<Contact>(filteredContacts);
                });
        }

        #region Properties
        private string _searchQuery = "";
        public string SearchQuery
        {
            get => _searchQuery;
            set { this.RaiseAndSetIfChanged(ref _searchQuery, value); }
        }

        private ObservableCollection<Contact> _contacts;
        public ObservableCollection<Contact> Contacts
        {
            get => _contacts;
            set { this.RaiseAndSetIfChanged(ref _contacts, value); }
        }

        #endregion
    }
}
