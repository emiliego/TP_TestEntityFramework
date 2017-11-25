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
using TestEntityFrameworkBDD.BDD;
using TestEntityFrameworkBDD.Vues;

namespace TestEntityFrameworkBDD.Controlers
{
    /// <summary>
    /// Logique d'interaction pour PersonneControl.xaml
    /// </summary>
    public partial class PersonneControl : UserControl
    {
        #region Constructeurs

        public PersonneControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.RefreshDatas();
        }

        #endregion

        #region Funcs

        public void RefreshDatas()
        {
            this.DataContext = ((App)App.Current).entity.Personne.ToList();
        }

        #endregion

        #region CRUD

        public void Ajouter()
        {
            PersonneWindow window = new PersonneWindow();
            window.ShowDialog();


            if (window.DialogResult.HasValue && window.DialogResult == true)
            {
                //Sauvegarde
                Personne personneToAdd = (Personne)window.DataContext;

                ((App)App.Current).entity.Personne.Add(personneToAdd);

                ((App)App.Current).entity.SaveChanges();
            }
            else
            {
                //On rafraichit l'entity pour éviter les erreurs de données "fantomes" mal déliées
                ((App)App.Current).entity = new ExerciceCSharp_BDDEntities();
            }

            RefreshDatas();
        }

        public void Modifier()
        {
            if (dataGridElements.SelectedItems.Count == 1)
            {
                //Faire la modif
                //Personne personneAModifier = dataGridElements.SelectedItem as Personne;
                Personne personneAModifier = (Personne)dataGridElements.SelectedItem;

                PersonneWindow window = new PersonneWindow(personneAModifier);
                window.ShowDialog();

                if (window.DialogResult.HasValue && window.DialogResult == true)
                {
                    //Sauvegarde
                    ((App)App.Current).entity.SaveChanges();
                }
                else
                {
                    //On rafraichit l'entity pour éviter les erreurs de données "fantomes" mal déliées
                    ((App)App.Current).entity = new ExerciceCSharp_BDDEntities();
                }
            }
            else
            {
                MessageBox.Show("Merci de sélectionner un et un élément maximum");
            }
            RefreshDatas();
        }

        public void Supprimer()
        {
            if (dataGridElements.SelectedItems.Count == 1)
            {
                //Faire la modif
                Personne personneASupprimer = (Personne)dataGridElements.SelectedItem;

                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet élément ?",
                                    "Suppression",
                                    MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    ((App)App.Current).entity.Personne.Remove(personneASupprimer);

                    //Sauvegarde
                    ((App)App.Current).entity.SaveChanges();
                }
                else
                {
                    //On rafraichit l'entity pour éviter les erreurs de données "fantomes" mal déliées
                    ((App)App.Current).entity = new ExerciceCSharp_BDDEntities();
                }
            }
            else
            {
                MessageBox.Show("Merci de sélectionner un et un élément maximum");
            }
            RefreshDatas();
        }

        #endregion

    }
}