using Calendar_Revisited.Services;
using Calendar_Revisited.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_Revisited.ViewModels
{
    public class AddressBookViewModel : ObservableObject
    {
        private object _currentView;
        public object CurrentView
        {
            get => _currentView;
            set => OnPropertyChanged(ref _currentView, value);
        }

        private BookViewModel _bookViewModel;
        public BookViewModel BookViewModel
        {
            get => _bookViewModel;
            set => OnPropertyChanged(ref _bookViewModel, value);
        }

        public AddressBookViewModel()
        {
            var dataService = new JsonContactDataService();
            var dialogService = new WindowDialogService();

            BookViewModel = new BookViewModel(dataService, dialogService);
            CurrentView = BookViewModel;
        }
    }
}
