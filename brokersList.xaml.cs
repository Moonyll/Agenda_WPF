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
    /// Logique d'interaction pour customersList.xaml
    /// </summary>
    public partial class brokersList : Page
    {
        // Regex
        string regexName = @"^[A-Za-zéèàêâôûùïüç\-]+$";
        //string regexSubject = @"^[A-Z0-9a-zéèàêâôûùïüç '\-]+$";
        string regexMail = @"[0-9a-zA-Z\.\-]+@[0-9a-zA-Z\.\-]+.[a-zA-Z]{2,4}";
        string regexPhone = @"^[0][0-9]{9}";
        //string regexBudget = @"^[0-9]";
        //
        bool isValid = true;
        int error = 0;
        //
        private Agenda db = new Agenda();
        Broker broker;
        int id_broker_todel;
        public brokersList()
        {
            InitializeComponent();
            //this.listing.MouseDoubleClick += this.DoubleClick;
            broker = new Broker();
        }
        private void Page_Broker_Loaded(object sender, RoutedEventArgs e)
        {
            //var request = "SELECT [idCustomer], [LastName], [FirstName], [Mail], [PhoneNumber], [Budget], [Subject] " +"FROM [dbo].[Customers] " +"ORDER BY [LastName] ASC";
            //var listCustomers = db.Customers.SqlQuery(request);
            //listing.ItemsSource = listCustomers.ToList();
            listing_brok.ItemsSource = db.Brokers.ToList();
        }
        private void Details(object sender, MouseButtonEventArgs e)
        {
            if (listing_brok.SelectedItem == null) return;
            broker = listing_brok.SelectedItem as Broker;
            id_broker_todel = broker.idBroker;// Si on veut supprimer ce courtier

            LastName.Text = broker.LastName;
            FirstName.Text = broker.FirstName;
            Mail.Text = broker.Mail;
            PhoneNumber.Text = broker.PhoneNumber;
            //Budget.Text = customer.Budget.ToString();
            //Subject.Text = customer.Subject;
        }
        private void UpdateBrok(object sender, RoutedEventArgs e)
        {
            //LASTNAME
            if (!String.IsNullOrEmpty(LastName.Text))
            {
                if (!Regex.IsMatch(LastName.Text, regexName))
                {
                    MessageBox.Show("Ecrire un nom valide");
                    isValid = false;
                    error++;
                }
                else
                {
                    broker.LastName = LastName.Text;
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Ecrire un nom");
                isValid = false;
                error++;
            }
            //FIRSTNAME
            if (!String.IsNullOrEmpty(FirstName.Text))
            {
                if (!Regex.IsMatch(FirstName.Text, regexName))
                {
                    MessageBox.Show("Ecrire un prenom valide");
                    isValid = false;
                    error++;
                }
                else
                {
                    broker.FirstName = FirstName.Text;
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Ecrire un prenom");
                isValid = false;
                error++;
            }
            //MAIL
            if (!String.IsNullOrEmpty(Mail.Text))
            {
                if (!Regex.IsMatch(Mail.Text, regexMail))
                {
                    MessageBox.Show("Ecrire un mail valide");
                    isValid = false;
                    error++;
                }
                else
                {
                    broker.Mail = Mail.Text;
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Ecrire un Mail");
                isValid = false;
                error++;
            }
            //PHONENUMBER
            if (!String.IsNullOrEmpty(PhoneNumber.Text))
            {
                if (!Regex.IsMatch(PhoneNumber.Text, regexPhone))
                {
                    MessageBox.Show("Ecrire un numéro valide");
                    isValid = false;
                    error++;
                }
                else
                {
                    broker.PhoneNumber = PhoneNumber.Text;
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Ecrire un numéro");
                isValid = false;
                error++;
            }
            ////BUDGET
            //if (!String.IsNullOrEmpty(Budget.Text))
            //{
            //    if (!Regex.IsMatch(Budget.Text, regexBudget))
            //    {
            //        MessageBox.Show("Donner la valeur du budget");
            //        isValid = false;
            //        error++;
            //    }
            //    else
            //    {
            //        broker.Budget = int.Parse(Budget.Text);
            //        MessageBox.Show("");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Ecrire un budget");
            //    isValid = false;
            //    error++;
            //}
            ////SUBJECT
            //if (!String.IsNullOrEmpty(Subject.Text))
            //{
            //    if (!Regex.IsMatch(Subject.Text, regexSubject))
            //    {
            //        MessageBox.Show("Ecrire un sujet valide");
            //        isValid = false;
            //        error++;
            //    }
            //    else
            //    {
            //        broker.Subject = Subject.Text;
            //        MessageBox.Show("");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Ecrire un sujet");
            //    isValid = false;
            //    error++;
            //}
            //// Enregistrement
            //customer.LastName = LastName.Text;
            //customer.FirstName = FirstName.Text;
            //customer.Mail = Mail.Text;
            //customer.PhoneNumber = PhoneNumber.Text;
            //customer.Budget = int.Parse(Budget.Text);
            //customer.Subject = Subject.Text;
            ////
            ///
            //SAUVEGARDE ET RESET
            if (isValid == true)
            {
                db.Entry(broker).State = EntityState.Modified;
                db.SaveChanges();
                LastName.Text = "";
                FirstName.Text = "";
                Mail.Text = "";
                PhoneNumber.Text = "";
                //Budget.Text = "";
                //Subject.Text = "";
                MessageBox.Show("Le client a bien été mis à jour");
                listing_brok.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Vous avez " + error + " Erreur(s)");
            }
            //db.Entry(customer).State = EntityState.Modified;
            //db.SaveChanges();
            //
            //MessageBox.Show("Le client a bien été mis à jour");
        }
        private void DelBrok(object sender, RoutedEventArgs e)
        {

            Broker broker = db.Brokers.Find(id_broker_todel);
            db.Brokers.Remove(broker);
            db.SaveChanges();

            MessageBox.Show("Le client a bien été supprimé");
            // Updating List
            listing_brok.ItemsSource = null;
            listing_brok.ItemsSource = db.Brokers.ToList();
        }
    }
}
