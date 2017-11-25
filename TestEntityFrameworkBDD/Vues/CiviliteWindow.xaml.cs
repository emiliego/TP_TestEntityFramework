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
    /// Logique d'interaction pour CiviliteWindow.xaml
    /// </summary>
    public partial class CiviliteWindow : Window
    {
        #region Constructeurs
        
        public CiviliteWindow(Civilite civiliteAModifier = null)
        {
            InitializeComponent();

            if (civiliteAModifier == null)
            {
                this.DataContext = new Civilite();
            }
            else
            {
                this.DataContext = civiliteAModifier;
            }

            //this.DataContext = civiliteAModifier == null ? new Civilite() : civiliteAModifier;
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

            if (!Verification_TextBoxLibelleLong())
            {
                toReturn = false;
            }
            if (!Verification_TextBoxLibelleCourt())
            {
                toReturn = false;
            }

            return toReturn;
        }

        public bool Verification_TextBoxLibelleLong()
        {
            bool toReturn = true;

            if (string.IsNullOrWhiteSpace(this.TextBoxLibelleLong.Text))
            {
                toReturn = false;
            }

            this.TextBoxLibelleLong.Background = toReturn ? Brushes.Green : Brushes.Red;

            return toReturn;
        }

        public bool Verification_TextBoxLibelleCourt()
        {
            bool toReturn = true;

            if (string.IsNullOrWhiteSpace(this.TextBoxLibelleCourt.Text))
            {
                toReturn = false;
            }

            this.TextBoxLibelleCourt.Background = toReturn ? Brushes.Green : Brushes.Red;

            return toReturn;
        }

        #endregion

    }
}
