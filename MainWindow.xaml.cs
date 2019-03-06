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

namespace Agenda_WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        InitializeComponent();
        //Window.Source = new Uri("customersList.xaml", UriKind.RelativeOrAbsolute);
        }
       
        private void AddingCust(object sender, RoutedEventArgs e)
        {
        Main.Content = new addCustomer();
        }

        private void ListingCust(object sender, RoutedEventArgs e)
        {
        Main.Content = new customersList();
        }
        private void AddingBrok(object sender, RoutedEventArgs e)
        {
            Main.Content = new addBroker();
        }

        private void ListingBrok(object sender, RoutedEventArgs e)
        {
            Main.Content = new brokersList();
        }
        private void AddingApp(object sender, RoutedEventArgs e)
        {
            Main.Content = new addAppointment();
        }
        private void ListingApp(object sender, RoutedEventArgs e)
        {
            Main.Content = new appointmentsList();
        }
    }

}
