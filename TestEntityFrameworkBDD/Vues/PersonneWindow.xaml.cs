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
using System.Windows.Shapes;
using TestEntityFrameworkBDD.BDD;

namespace TestEntityFrameworkBDD.Vues
{
    /// <summary>
    /// Logique d'interaction pour PersonneWindow.xaml
    /// </summary>
    public partial class PersonneWindow : Window
    {
        #region Constructeurs

        public PersonneWindow(Personne personneAModifier = null)
        {
            InitializeComponent();

            if (personneAModifier == null)
            {
                this.DataContext = new Personne();
            }
            else
            {
                this.DataContext = personneAModifier;
            }

            //this.DataContext = personneAModifier == null ? new Personne() : personneAModifier;
        }

        #endregion

        #region Events

        private void ButtonValider_Click(object sender, RoutedEventArgs e)
        {
            if (VerificationChamps())
            {
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                //On ne fait rien !
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        #endregion

        #region Funcs

        public bool VerificationChamps()
        {
            bool toReturn = true;

            if (!Verification_TextBoxCivilite())
            {
                toReturn = false;
            }
            if (!Verification_TextBoxNom())
            {
                toReturn = false;
            }
            if (!Verification_TextBoxPrenom())
            {
                toReturn = false;
            }
            if (!Verification_TextBoxAdresse())
            {
                toReturn = false;
            }
            if (!Verification_TextBoxVille())
            {
                toReturn = false;
            }

            return toReturn;
        }

        public bool Verification_TextBoxCivilite()
        {
            bool toReturn = true;

            if (string.IsNullOrWhiteSpace(this.TextBoxCivilite.Text))
            {
                toReturn = false;
            }

            this.TextBoxCivilite.Background = toReturn ? Brushes.Green : Brushes.Red;

            return toReturn;
        }

        public bool Verification_TextBoxNom()
        {
            bool toReturn = true;

            if (string.IsNullOrWhiteSpace(this.TextBoxNom.Text))
            {
                toReturn = false;
            }

            this.TextBoxCodeNom.Background = toReturn ? Brushes.Green : Brushes.Red;

            return toReturn;
        }
        public bool Verification_TextBoxPrenom()
        {
            bool toReturn = true;

            if (string.IsNullOrWhiteSpace(this.TextBoxPrenom.Text))
            {
                toReturn = false;
            }

            this.TextBoxCodePrenom.Background = toReturn ? Brushes.Green : Brushes.Red;

            return toReturn;
        }
        public bool Verification_TextBoxAdresse()
        {
            bool toReturn = true;

            if (string.IsNullOrWhiteSpace(this.TextBoxAdresse.Text))
            {
                toReturn = false;
            }

            this.TextBoxAdresse.Background = toReturn ? Brushes.Green : Brushes.Red;

            return toReturn;
        }
        public bool Verification_TextBoxVille()
        {
            bool toReturn = true;

            if (string.IsNullOrWhiteSpace(this.TextBoxVille.Text))
            {
                toReturn = false;
            }

            this.TextBoxVille.Background = toReturn ? Brushes.Green : Brushes.Red;

            return toReturn;
        }

        #endregion

    }
}
