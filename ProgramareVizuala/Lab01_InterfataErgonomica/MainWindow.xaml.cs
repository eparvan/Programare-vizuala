using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab01_InterfataErgonomica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTrimite_Click(object sender, RoutedEventArgs e)
        {
            string nume = txtNume.Text.Trim(); 
            string prenume = txtPrenume.Text.Trim(); 
            string grupa = txtGrupa.Text.Trim(); 
            string scop = txtScop.Text.Trim(); 
            // Verificăm dacă toate câmpurile obligatorii sunt completate.
            if (string.IsNullOrWhiteSpace(nume) || 
                string.IsNullOrWhiteSpace(prenume) || 
                string.IsNullOrWhiteSpace(grupa) || 
                string.IsNullOrWhiteSpace(scop)) 
            { 
                txtMesaj.Text = "Eroare: completează toate câmpurile obligatorii."; 
                txtMesaj.Foreground = Brushes.Firebrick;
                return; 
            } 
            string tipCerere; 
            if (chkUrgenta.IsChecked == true) 
            { 
                tipCerere = "urgentă"; 
            } else 
            { 
                tipCerere = "obișnuită"; 
            } 
            txtMesaj.Text = $"Succes: cererea pentru {nume} {prenume}, " 
                + $"grupa {grupa}, a fost înregistrată. " 
                + $"Cererea este {tipCerere}."; 
            txtMesaj.Foreground = Brushes.DarkGreen;
        }

        private void btnGoleste_Click(object sender, RoutedEventArgs e)
        {
            txtNume.Clear(); 
            txtPrenume.Clear(); 
            txtGrupa.Clear(); 
            txtScop.Clear(); 
            chkUrgenta.IsChecked = false; 
            txtMesaj.Text = "Formularul a fost golit. Poți introduce o cerere nouă."; 
            txtMesaj.Foreground = Brushes.DarkBlue; 
            txtNume.Focus();
        }
    }
}