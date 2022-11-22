using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TD
{
    public class MainViewModel : ViewModelBase
    {
        private string _titre;
        ObservableCollection<string> liste = new ObservableCollection<string>();
        ObservableCollection<string> detail = new ObservableCollection<string>();

        ObservableCollection<string> liste2 = new ObservableCollection<string>();
        private int nb_piste = 0;

        public MainViewModel()
        {
            _titre = "Appli Musique";
            Liste();
        }


        public void Liste()
        {
            liste.Add(detail.Add());
            liste.Add("John Lenon - Imagine");
            //Console.WriteLine(liste);
            OnPropertyChanged(nameof(liste));
        }

        public void Ajouter_gauche()
        {
            liste.Add("Artiste - Album");
            OnPropertyChanged(nameof(liste));
        }

        public void Supprimer_gauche(int index)
        {
            liste.RemoveAt(index);
            OnPropertyChanged(nameof(liste));
        }

        public void Ajouter_piste(String nm_piste)
        {
            String piste = nm_piste;
            nb_piste++;
            liste2.Add(nb_piste + " - " + piste);
            OnPropertyChanged(nameof(liste2));
        }

        public void Supprimer_piste(int index)
        {
            liste2.RemoveAt(index);
            OnPropertyChanged(nameof(liste));
        }

        public string Artiste()
        {
        }

        // La liaison de données XAML ne reconnait que les propriétés.

        public string Titre
        {
            get { return _titre; }
        }

        public ObservableCollection<String> Result_liste
        {
            get { return liste; }
        }

        public ObservableCollection<String> Result_liste2
        {
            get { return liste2; }
        }

        public string Compositeur
        {

        }

    }
}
