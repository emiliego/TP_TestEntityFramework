using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TestEntityFrameworkBDD
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {

        public BDD.ExerciceCSharp_BDDEntities entity = new BDD.ExerciceCSharp_BDDEntities();

    }
}
