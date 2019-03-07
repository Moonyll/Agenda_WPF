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
    /// Logique d'interaction pour addAppointment.xaml
    /// </summary>
    public partial class addAppointment : Page
    {
        private Agenda db = new Agenda();
        Appointment new_appointment;
        Broker selected_broker;
        Customer selected_customer;
        string selected_date;
        string selected_hour;
        string selected_minute;
        string rdv_date;
       
        public addAppointment()
        {
            InitializeComponent();
            selected_broker = new Broker();
            selected_customer = new Customer();
            new_appointment = new Appointment();
        }
        private void Combo(object sender, RoutedEventArgs e)
        {
            Broker_Choice.ItemsSource = db.Brokers.ToList();
            Customer_Choice.ItemsSource = db.Customers.ToList();
        }
        private void addingApp(object sender, RoutedEventArgs e)
        {
                        
            selected_broker.idBroker = Convert.ToInt32(Broker_Choice.SelectedValue);
            selected_customer.idCustomer = Convert.ToInt32(Customer_Choice.SelectedValue);

            selected_date = datePicker.Text;
            selected_hour = Hour.Text;
            selected_minute = Minutes.Text;
            rdv_date = selected_date +" "+ selected_hour +":"+ selected_minute;
            //
            new_appointment.DateHour = Convert.ToDateTime(rdv_date);
            //
            new_appointment.idBroker = selected_broker.idBroker;
            new_appointment.idCustomer = selected_customer.idCustomer;
            //
            db.Appointments.Add(new_appointment);
            db.SaveChanges();
            //
            MessageBox.Show("Le rendez-vous a bien été ajouté");
        }
    }
}
