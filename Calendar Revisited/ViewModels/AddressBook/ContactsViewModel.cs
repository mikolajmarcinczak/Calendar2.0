using Calendar_Revisited.Models;
using Calendar_Revisited.Services;
using Calendar_Revisited.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calendar_Revisited.ViewModels
{
    public class ContactsViewModel : ObservableObject
    {
        private UserContact _selectedContact;
        public UserContact SelectedContact
        {
            get { return _selectedContact; }
            set { OnPropertyChanged(ref _selectedContact, value); }
        }

        private bool _isEditMode;
        public bool IsEditMode
        {
            get { return _isEditMode; }
            set
            {
                OnPropertyChanged(ref _isEditMode, value);
                OnPropertyChanged("IsDisplayMode");
            }
        }

        public bool IsDisplayMode
        {
            get { return !_isEditMode; }
        }

        public ObservableCollection<UserContact> Contacts { get; private set; }

        public ICommand EditCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand InsertOrUpdateCommand { get; }

        private IContactDataService _dataService;
        private IDialogService _dialogService;

        public ContactsViewModel(IContactDataService dataService, IDialogService dialogService)
        {
            _dataService = dataService;
            _dialogService = dialogService;
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
