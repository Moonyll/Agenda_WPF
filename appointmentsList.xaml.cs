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
        //Appointment up_appointment;
        Broker selected_broker;
        Customer selected_customer;
        string new_date;
        string new_hour;
        string new_minute;
        string new_rdv_date;

        public appointmentsList()
        {
            InitializeComponent();
            selected_broker = new Broker();
            selected_customer = new Customer();
            
        }
        private void Page_Appointment_Loaded(object sender, RoutedEventArgs e)
        {
            var list_appointments = db.Appointments.Include(a => a.Broker).Include(a => a.Customer).OrderBy(x => x.DateHour);
            listing_app.ItemsSource = list_appointments.ToList();
        }
        private void UpdateApp(object sender, RoutedEventArgs e)
        {
            //
            int id_up_app = Convert.ToInt32(App_id.Text);
            //
            Appointment up_appointment = db.Appointments.Find(id_up_app);
            //
            new_date = App_Date.Text;
            new_hour = App_Hour.Text;
            new_minute = App_Minutes.Text;
            //
            new_rdv_date = new_date + " " + new_hour + ":" + new_minute;
            //
            up_appointment.DateHour = Convert.ToDateTime(new_rdv_date);
            //
            up_appointment.idBroker = Convert.ToInt32(App_idBrok.Text);
            up_appointment.idCustomer = Convert.ToInt32(App_idCust.Text);
            //   
            db.Entry(up_appointment).State = EntityState.Modified;// Mise à jour
            db.SaveChanges(); // Enregistrement des changements
            //
            MessageBox.Show("Le rendez-vous a bien été mis à jour");
            // Updating List
            listing_app.ItemsSource = null;
            listing_app.ItemsSource = db.Appointments.ToList();
            //
        }
        private void DelApp(object sender, RoutedEventArgs e)
        {
            int id_App_Todel = Convert.ToInt32(App_id.Text);
            Appointment del_App = db.Appointments.Find(id_App_Todel);
            db.Appointments.Remove(del_App);
            db.SaveChanges();
            //
            MessageBox.Show("Le rendez-vous a bien été supprimé");
            // Updating List
            listing_app.ItemsSource = null;
            listing_app.ItemsSource = db.Appointments.ToList();
        }
    }
}
