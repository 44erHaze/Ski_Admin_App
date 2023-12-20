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
    public partial class ServiceAuftragsListePage : Page
    {
        public ServiceAuftragsListePage()
        {
            InitializeComponent();
            UpdateList();
        }

        private void UpdateList()
        {
            // Implementiere die Logik zum Laden und Filtern der Serviceaufträge
            lstServiceAufträge.ItemsSource = GetFilteredServiceAufträge(txtSearch.Text);
        }

        private List<ServiceAuftrag> GetFilteredServiceAufträge(string searchTerm)
        {
            // Hier könntest du die Serviceaufträge aus der Datenbank laden und filtern
            // Beispiel: Dummy-Daten (ersetze durch deine eigene Logik)
            List<ServiceAuftrag> serviceAufträge = new List<ServiceAuftrag>
        {
            new ServiceAuftrag { AuftragsID = 1, Kundenname = "Max Mustermann", Dienstleistung = "Kleiner Service", Status = "Offen" },
            new ServiceAuftrag { AuftragsID = 2, Kundenname = "Erika Musterfrau", Dienstleistung = "Grosser Service", Status = "In-Arbeit" },
        };

            if (!string.IsNullOrEmpty(searchTerm))
            {
                serviceAufträge = serviceAufträge
                    .Where(auftrag => auftrag.Kundenname.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return serviceAufträge;
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateList();
        }
    }

}
