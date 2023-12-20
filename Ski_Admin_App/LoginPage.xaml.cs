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

namespace Ski_Admin_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Implementiere den Login-Code
            if (IsValidLogin(username, password))
            {
                // Erfolgreicher Login
                NavigationService.Navigate(new ServiceAuftragsListePage());
            }
            else
            {
                // Fehlermeldung anzeigen
                MessageBox.Show("Ungültige Anmeldeinformationen.");
            }
        }

        private bool IsValidLogin(string username, string password)
        {
            // Hier könntest du die Anmeldeinformationen mit einer Datenbank oder einem anderen Mechanismus überprüfen
            // Beispiel: Dummy-Anmeldung (ersetze durch deine eigene Logik)
            return username == "admin" && password == "pass123";
        }
    }

}
