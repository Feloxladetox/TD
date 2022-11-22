using System;
using System.Collections.Generic;
using System.IO;
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

namespace TD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index;
        String nm_piste;

        public MainWindow()
        {
            InitializeComponent();

            // Définition de la vue-modèle par la fenêtre.
            // Par convention, nous allons plutôt la définir
            // au démarrage de l'application (classe App).
            
            // DataContext = new MainViewModel();

            // Abonnement à un évènement
            // Equivalent avec Loaded="MainWindow_Loaded" en XAML
            //Loaded += MainWindow_Loaded;
        }

        MainViewModel vm = new MainViewModel();
        

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainViewModel vm)
            {
                vm.Ajouter_gauche();
            }
        }

        private void button_Click1(object sender, RoutedEventArgs e)
        {
            index = List.SelectedIndex;
            if (DataContext is MainViewModel vm)
            {
                vm.Supprimer_gauche(index);
            }
        }

        private void button_Click2(object sender, RoutedEventArgs e)
        {
            nm_piste = Pist.Text;
            if (DataContext is MainViewModel vm)
            {
                vm.Ajouter_piste(nm_piste);
            }

        }

        private void button_Click3(object sender, RoutedEventArgs e)
        {
            index = List2.SelectedIndex;
            if (DataContext is MainViewModel vm)
            {
                vm.Supprimer_piste(index);
            }
        }



        // Déclenché lorsque la fenêtre est chargée.
        /*private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainViewModel vm)
            {
                artiste = List.SelectedItems.ToString();
                //vm.Heure();
            }
        }*/

        // Si l'on était abonné à l'évènement Click du bouton,
        // à la place d'une commande :
        //
        // private void Button_Click(object sender, RoutedEventArgs e)
        // {
        //     if (DataContext is MainViewModel vm)
        //     {
        //         vm.Heure();
        //     }
        // }
    }
}
