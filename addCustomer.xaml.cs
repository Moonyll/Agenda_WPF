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
using System.Text.RegularExpressions;

namespace Agenda_WPF
{
    /// <summary>
    /// Logique d'interaction pour addCustomer.xaml
    /// </summary>
    public partial class addCustomer : Page
    {
        // Regex
        string regexName = @"^[A-Za-zéèàêâôûùïüç\-]+$";
        string regexSubject = @"^[A-Z0-9a-zéèàêâôûùïüç '\-]+$";
        string regexMail = @"[0-9a-zA-Z\.\-]+@[0-9a-zA-Z\.\-]+.[a-zA-Z]{2,4}";
        string regexPhone = @"^[0][0-9]{9}";
        string regexBudget = @"^[0-9]";
        //
        bool isValid = true;
        int error = 0;
        //
        private Agenda db = new Agenda();
        public addCustomer()
        {
        InitializeComponent();
        
        }
        private void AddCust(object sender, RoutedEventArgs e)
        {
            //Instanciation
            Customer add_customer = new Customer();
            // Enregistrement
            //
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
                    add_customer.LastName = LastName.Text;
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
                    add_customer.FirstName = FirstName.Text;
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
                    add_customer.Mail = Mail.Text;
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
                    add_customer.PhoneNumber = PhoneNumber.Text;
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Ecrire un numéro");
                isValid = false;
                error++;
            }
            //BUDGET
            if (!String.IsNullOrEmpty(Budget.Text))
            {
                if (!Regex.IsMatch(Budget.Text, regexBudget))
                {
                    MessageBox.Show("Donner la valeur du budget");
                    isValid = false;
                    error++;
                }
                else
                {
                    add_customer.Budget = int.Parse(Budget.Text);
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Ecrire un budget");
                isValid = false;
                error++;
            }
            //SUBJECT
            if (!String.IsNullOrEmpty(Subject.Text))
            {
                if (!Regex.IsMatch(Subject.Text, regexSubject))
                {
                    MessageBox.Show("Ecrire un sujet valide");
                    isValid = false;
                    error++;
                }
                else
                {
                    add_customer.Subject = Subject.Text;
                    MessageBox.Show("");
                }
            }
            else
            {
                MessageBox.Show("Ecrire un sujet");
                isValid = false;
                error++;
            }
            //SAUVEGARDE ET RESET
            if (isValid == true)
            {
                db.Customers.Add(add_customer);
                db.SaveChanges();
                LastName.Text = "";
                FirstName.Text = "";
                Mail.Text = "";
                PhoneNumber.Text = "";
                Budget.Text = "";
                Subject.Text = "";
                MessageBox.Show("Le client a bien été ajouté"); 
            }
            else
            {
                MessageBox.Show("Vous avez " + error + " Erreur(s)");
            }
            //
            //add_customer.LastName = LastName.Text;
            //add_customer.FirstName = FirstName.Text;
            //add_customer.Mail = Mail.Text;
            //add_customer.PhoneNumber = PhoneNumber.Text;
            //add_customer.Budget = int.Parse(Budget.Text);
            //add_customer.Subject = Subject.Text;
            //MessageBox.Show("Le client a bien été ajouté");
            //db.Customers.Add(add_customer);
            //db.SaveChanges();
            //
        }
        private void Return(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("customersList.xaml", UriKind.Relative));
        }
    }
}
