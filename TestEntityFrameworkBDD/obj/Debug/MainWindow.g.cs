﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ABAAD53FEEFC3BE9F3CB18DE4946196A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TestEntityFrameworkBDD;
using TestEntityFrameworkBDD.Controlers;


namespace TestEntityFrameworkBDD {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemAjouter;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemModifier;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemSupprimer;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemQuitter;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemModuleCivilites;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemModuleVilles;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MenuItemModulePersonnes;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridContenuModule;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TestEntityFrameworkBDD;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.MenuItemAjouter = ((System.Windows.Controls.MenuItem)(target));
            
            #line 23 "..\..\MainWindow.xaml"
            this.MenuItemAjouter.Click += new System.Windows.RoutedEventHandler(this.MenuItemAjouter_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MenuItemModifier = ((System.Windows.Controls.MenuItem)(target));
            
            #line 24 "..\..\MainWindow.xaml"
            this.MenuItemModifier.Click += new System.Windows.RoutedEventHandler(this.MenuItemModifier_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MenuItemSupprimer = ((System.Windows.Controls.MenuItem)(target));
            
            #line 25 "..\..\MainWindow.xaml"
            this.MenuItemSupprimer.Click += new System.Windows.RoutedEventHandler(this.MenuItemSupprimer_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MenuItemQuitter = ((System.Windows.Controls.MenuItem)(target));
            
            #line 27 "..\..\MainWindow.xaml"
            this.MenuItemQuitter.Click += new System.Windows.RoutedEventHandler(this.MenuItemQuitter_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MenuItemModuleCivilites = ((System.Windows.Controls.MenuItem)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.MenuItemModuleCivilites.Click += new System.Windows.RoutedEventHandler(this.MenuItemModuleCivilites_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MenuItemModuleVilles = ((System.Windows.Controls.MenuItem)(target));
            
            #line 31 "..\..\MainWindow.xaml"
            this.MenuItemModuleVilles.Click += new System.Windows.RoutedEventHandler(this.MenuItemModuleVilles_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MenuItemModulePersonnes = ((System.Windows.Controls.MenuItem)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.MenuItemModulePersonnes.Click += new System.Windows.RoutedEventHandler(this.MenuItemModulePersonnes_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.GridContenuModule = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

