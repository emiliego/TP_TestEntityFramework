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
    /// Logique d'interaction pour VilleWindow.xaml
    /// </summary>
    public partial class VilleWindow : Window
    {
        #region Constructeurs

        public VilleWindow(Ville villeAModifier = null)
        {
            //InitializeComponent();

            if (villeAModifier == null)
            {
                this.DataContext = new Ville();
            }
            else
            {
                this.DataContext = villeAModifier;
            }

            //this.DataContext = villeAModifier == null ? new Ville() : villeAModifier;
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

            if (!Verification_TextBoxLibelle())
            {
                toReturn = false;
            }
            if (!Verification_TextBoxCodePostal())
            {
                toReturn = false;
            }

            return toReturn;
        }

        public bool Verification_TextBoxLibelle()
        {
            bool toReturn = true;

            if (string.IsNullOrWhiteSpace(this.TextBoxLibelle.Text))
            {
                toReturn = false;
            }

            this.TextBoxLibelle.Background = toReturn ? Brushes.Green : Brushes.Red;

            return toReturn;
        }

        public bool Verification_TextBoxCodePostal()
        {
            bool toReturn = true;

            if (string.IsNullOrWhiteSpace(this.TextBoxCodePostal.Text))
            {
                toReturn = false;
            }

            this.TextBoxCodePostal.Background = toReturn ? Brushes.Green : Brushes.Red;

            return toReturn;
        }

        #endregion

    }
}
