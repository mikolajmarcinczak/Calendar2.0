using Calendar_Revisited.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_Revisited.Services
{
    public class JsonContactDataService : IContactDataService
    {
        private readonly string _dataPath = @"../../../Resources/ContactData.json";

        public IEnumerable<UserContact> GetContacts()
        {
            if (!File.Exists(_dataPath))
            {
                File.Create(_dataPath).Close();
            }

            var serializedContacts = File.ReadAllText(_dataPath);
            var contacts = JsonConvert.DeserializeObject<IEnumerable<UserContact>>(serializedContacts);

            if (contacts == null)
            {
                return new List<UserContact>();
            }

            return contacts;
        }

        public void Save(IEnumerable<UserContact> contacts)
        {
            var serializedContacts = JsonConvert.SerializeObject(contacts);
            File.WriteAllText(_dataPath, serializedContacts);
        }
    }
}
