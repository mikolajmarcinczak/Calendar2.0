using Calendar_Revisited.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_Revisited.Services
{
    public interface IContactDataService
    {
        IEnumerable<UserContact> GetContacts();
        void Save(IEnumerable<UserContact> contacts);
    }
}
