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

namespace APP_BD
{
    /// <summary>
    /// Logique d'interaction pour Cours.xaml
    /// </summary>
    public partial class Cours : Page
    {
        public Cours()
        {
            InitializeComponent();
        }

        private void cours(object sender, RoutedEventArgs e)
        {
            // Créez une instance de la nouvelle fenêtre ou de la nouvelle page
            var nextPage = new Enregistre_Cours();


            // Faites disparaître le contenu du Grid en le rendant invisible
            MainGrid.Visibility = Visibility.Collapsed;

            // Définissez la nouvelle page comme contenu du Frame
            MainContentFrame.Content = nextPage;
        }
    }
}
