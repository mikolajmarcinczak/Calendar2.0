using Calendar_Revisited.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_Revisited.Services
{
    public class DataService : IContactDataService
    {
        private IEnumerable<UserContact> _contacts;

        public IEnumerable<UserContact> GetContacts()
        {
            return _contacts;
        }

        public void Save(IEnumerable<UserContact> contacts)
        {
            _contacts = contacts;
        }
    }
}
