using Calendar_Revisited.Services;
using Calendar_Revisited.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calendar_Revisited.ViewModels
{
    public class BookViewModel : ObservableObject
    {
        private IContactDataService _contactDataService;

        private ContactsViewModel _contactsViewModel;
        public ContactsViewModel ContactsViewModel
        {
            get { return _contactsViewModel; }
            set { OnPropertyChanged(ref _contactsViewModel, value); }
        }

        public ICommand LoadContactsCommand { get; private set; }
        public ICommand LoadFavoritesCommand { get; private set; }

        public BookViewModel(IContactDataService service, IDialogService dialogService)
        {
            ContactsViewModel = new ContactsViewModel(service, dialogService);

            _contactDataService = service;

            LoadContacts();
            LoadContactsCommand = new RelayCommand(LoadContacts);
            LoadFavoritesCommand = new RelayCommand(LoadFavorites);
        }

        private void LoadContacts()
        {
            ContactsViewModel.LoadContacts(_contactDataService.GetContacts());
        }

        private void LoadFavorites()
        {
            var favorites = _contactDataService.GetContacts().Where(c => c.IsFavorite);
            ContactsViewModel.LoadContacts(favorites);
        }
    }
}
