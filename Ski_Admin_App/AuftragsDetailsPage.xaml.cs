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
    public partial class AuftragsDetailsPage : Page
    {
        private ServiceAuftrag selectedAuftrag;

        public AuftragsDetailsPage(ServiceAuftrag auftrag)
        {
            InitializeComponent();
            selectedAuftrag = auftrag;
            UpdateDetails();
        }

        private void UpdateDetails()
        {
            // Implementiere die Logik zum Laden und Anzeigen der Auftragsdetails
            txtAuftragsDetails.Text = $"Auftragsdetails für ID {selectedAuftrag.AuftragsID}:\n\n" +
                $"Kunde: {selectedAuftrag.Kundenname}\n" +
                $"Dienstleistung: {selectedAuftrag.Dienstleistung}\n" +
                $"Status: {selectedAuftrag.Status}";
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            // Implementiere die Logik zum Aktualisieren des Auftrags (z.B., Status ändern)
            selectedAuftrag.Status = cmbStatus.SelectedItem.ToString();
            UpdateDetails();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Implementiere die Logik zum Löschen des Auftrags
            MessageBoxResult result = MessageBox.Show("Möchten Sie diesen Auftrag wirklich löschen?", "Bestätigung", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                // Führe Löschaktion durch (z.B., aus der Datenbank entfernen)
                MessageBox.Show("Auftrag wurde gelöscht.");
            }
        }
    }

}
