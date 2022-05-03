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
        }

        private void LoadContacts()
        {

        }

        private void LoadFavorites()
        {

        }
    }
}
