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
using TestEntityFrameworkBDD.Controlers;

namespace TestEntityFrameworkBDD
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }        

        private void MenuItemAjouter_Click(object sender, RoutedEventArgs e)
        {
            if (this.GridContenuModule.Children.Count >= 1)
            {
                object moduleCharge = null;
                foreach (var item in this.GridContenuModule.Children)
                {
                    moduleCharge = item;
                }

                if (moduleCharge is CiviliteControl)
                {
                    ((CiviliteControl)moduleCharge).Ajouter();
                }

                if (moduleCharge is PersonneControl)
                {
                    ((PersonneControl)moduleCharge).Ajouter();
                }

                if (moduleCharge is VilleControl)
                {
                    ((VilleControl)moduleCharge).Ajouter();
                }
            }
        }

        private void MenuItemModifier_Click(object sender, RoutedEventArgs e)
        {
            if (this.GridContenuModule.Children.Count >= 1)
            {
                object moduleCharge = null;
                foreach (var item in this.GridContenuModule.Children)
                {
                    moduleCharge = item;
                }

                if (moduleCharge is CiviliteControl)
                {
                    ((CiviliteControl)moduleCharge).Modifier();
                }
                if (moduleCharge is PersonneControl)
                {
                    ((PersonneControl)moduleCharge).Modifier();
                }
                if (moduleCharge is VilleControl)
                {
                    ((VilleControl)moduleCharge).Modifier();
                }
            }
        }

        private void MenuItemSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (this.GridContenuModule.Children.Count >= 1)
            {
                object moduleCharge = null;
                foreach (var item in this.GridContenuModule.Children)
                {
                    moduleCharge = item;
                }

                if (moduleCharge is CiviliteControl)
                {
                    ((CiviliteControl)moduleCharge).Supprimer();
                }
                if (moduleCharge is PersonneControl)
                {
                    ((PersonneControl)moduleCharge).Supprimer();
                }
                if (moduleCharge is VilleControl)
                {
                    ((VilleControl)moduleCharge).Supprimer();
                }
            }
        }

        private void MenuItemQuitter_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItemModuleCivilites_Click(object sender, RoutedEventArgs e)
        {
            this.GridContenuModule.Children.Clear();
            this.GridContenuModule.Children.Add(new Controlers.CiviliteControl());
        }

        private void MenuItemModuleVilles_Click(object sender, RoutedEventArgs e)
        {
            this.GridContenuModule.Children.Clear();
            this.GridContenuModule.Children.Add(new Controlers.VilleControl());
        }

        private void MenuItemModulePersonnes_Click(object sender, RoutedEventArgs e)
        {
            this.GridContenuModule.Children.Clear();
            this.GridContenuModule.Children.Add(new Controlers.PersonneControl());
        }
    }
}
