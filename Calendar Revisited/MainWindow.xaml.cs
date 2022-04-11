using Calendar_Revisited.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calendar_Revisited
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SettingsView_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new SettingsViewModel();
        }

        private void CalendarView_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new CalendarViewModel();
        }

        private void ContactsView_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new ContactsViewModel();
        }

        private void NotepadView_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new NotepadViewModel();
        }

    }
}
