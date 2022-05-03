using Calendar_Revisited.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calendar_Revisited.ViewModels
{
    public class ContactsViewModel
    {
        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand InsertOrUpdateCommand { get; }
        public UserContact Contact { get; set; }

        public ContactsViewModel()
        {
            Contact = new UserContact();

        }

        private void EditContact()
        {

        }

        private void DeleteContact()
        {

        }

        private void InsertOrUpdate()
        {

        }


    }
}
