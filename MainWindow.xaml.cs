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
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer(); // Affichage du temps

        public MainWindow()
        {
            InitializeComponent();
            //
            Timer.Tick += new EventHandler(Timer_Click); // Incrémentation quand l'interval de 1 seconde est écoulé et appel de la méthode qui affiche le temps dans la textbox Horloge
            Timer.Interval = new TimeSpan(0, 0, 1); // Intervalle de temps de 1 seconde
            Timer.Start(); // Départ de l'horloge
        }
        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime today; // Date du jour
            today = DateTime.Now; // Variable today qui prend la valeur de la date du jour
            Horloge.Text = today.Hour + " : " + today.Minute + " : " + today.Second; // Concaténation
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
        /* Autre méthode :
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
        string clickedMenuItem = (sender as MenuItem).Name;
        Main.Source = new Uri(clickedMenuItem + ".xaml", UriKind.Relative);
        }
        */
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

        private void Home(object sender, RoutedEventArgs e)
        {
            Main.Content = new Accueil();
        }
        private void Window_Start(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new System.Uri("customersList.xaml", UriKind.RelativeOrAbsolute));
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
