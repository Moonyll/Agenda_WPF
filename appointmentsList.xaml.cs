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
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Text.RegularExpressions;

namespace Agenda_WPF
{
    /// <summary>
    /// Logique d'interaction pour appointmentsList.xaml
    /// </summary>
    public partial class appointmentsList : Page
    {
        private Agenda db = new Agenda();
        
        public appointmentsList()
        {
            InitializeComponent();
        }
        private void Page_Appointment_Loaded(object sender, RoutedEventArgs e)
        {
            var list_appointments = db.Appointments.Include(a => a.Broker).Include(a => a.Customer).OrderBy(x => x.DateHour);
            listing_app.ItemsSource = list_appointments.ToList();
        }
    }
}
