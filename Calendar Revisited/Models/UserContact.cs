using Calendar_Revisited.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_Revisited.Models
{
    public class UserContact : ObservableObject
    {
        private string _contactName;
        public string ContactName 
        { 
            get { return _contactName; }
            set { OnPropertyChanged(ref _contactName, value); }
        }

        private string _phoneNumber;
        public string PhoneNumber 
        { 
            get { return _phoneNumber; }
            set { OnPropertyChanged(ref _phoneNumber, value); }
        }

        private string _mailAddress
        public string MailAddress 
        {
            get { return _mailAddress; }
            set { OnPropertyChanged(ref _mailAddress, value); }
        }


    }
}
