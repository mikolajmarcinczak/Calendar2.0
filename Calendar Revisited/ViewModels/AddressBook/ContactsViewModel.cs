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
            get => _selectedContact;
            set => OnPropertyChanged(ref _selectedContact, value); 
        }

        private bool _isEditMode;
        public bool IsEditMode
        {
            get => _isEditMode; 
            set
            {
                OnPropertyChanged(ref _isEditMode, value);
                OnPropertyChanged("IsDisplayMode");
            }
        }

        public bool IsDisplayMode
        {
            get => !_isEditMode; 
        }

        public ObservableCollection<UserContact> Contacts { get; private set; }

        public ICommand EditCommand { get; private set; }
        public ICommand UpdateCommand { get; private set; }
        public ICommand InsertCommand { get; private set; }
        public ICommand DeleteCommand { get; private set; }
        public ICommand BrowseImageCommand { get; private set; }
        public ICommand SaveCommand { get; private set; }

        private IContactDataService _dataService;
        private IDialogService _dialogService;

        public ContactsViewModel(IContactDataService dataService, IDialogService dialogService)
        {
            _dataService = dataService;
            _dialogService = dialogService;

            EditCommand = new RelayCommand(EditContact, CanEdit);
            UpdateCommand = new RelayCommand(UpdateContact, IsEdit);
            InsertCommand = new RelayCommand(InsertContact);
            DeleteCommand = new RelayCommand(DeleteContact, CanDelete);

            BrowseImageCommand = new RelayCommand(BrowseImage, IsEdit);
            SaveCommand = new RelayCommand(Save, IsEdit);
            
        }
        
        private bool IsEdit()
        {
            return IsEditMode;
        }

        private bool CanEdit()
        {
            if (SelectedContact == null)
            {
                return false;
            }
            return !IsEditMode;
        }

        private void EditContact()
        {
            IsEditMode = true;
        }
        private void InsertContact()
        {
            var newContact = new UserContact
            {
                ContactName = "N/A",
                PhoneNumber = "N/A",
                MailAddress = "N/A"
            };

            Contacts.Add(newContact);
            SelectedContact = newContact;
        }

        private bool CanDelete()
        {
            return SelectedContact == null ? false : true;
        }

        private void DeleteContact()
        {
            Contacts.Remove(SelectedContact);
            Save();
        }
        private void Save()
        {
            _dataService.Save(Contacts);
            IsEditMode = false;
            OnPropertyChanged("SelectedContact");
        }

        private void UpdateContact()
        {
            _dataService.Save(Contacts);
        }


        private void BrowseImage()
        {
            var filePath = _dialogService.OpenFile("Image files|*.bmp;*.jpg;*.jpeg;*.png|All files");
            SelectedContact.ImagePath = filePath;
        }

        public void LoadContacts(IEnumerable<UserContact> contacts)
        {
            Contacts = new ObservableCollection<UserContact>(contacts);
            OnPropertyChanged("Contacts");
        }
    }
}
