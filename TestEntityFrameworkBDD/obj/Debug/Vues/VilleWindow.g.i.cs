﻿#pragma checksum "..\..\..\Vues\VilleWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3381749C9A906112A1D352879AE1FBA3"
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
using TestEntityFrameworkBDD.Vues;


namespace TestEntityFrameworkBDD.Vues {
    
    
    /// <summary>
    /// VilleWindow
    /// </summary>
    public partial class VilleWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\Vues\VilleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockLibelle;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Vues\VilleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLibelle;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Vues\VilleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockCodePostal;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Vues\VilleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxCodePostal;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Vues\VilleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonValider;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\Vues\VilleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/TestEntityFrameworkBDD;component/vues/villewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Vues\VilleWindow.xaml"
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
            this.TextBlockLibelle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.TextBoxLibelle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBlockCodePostal = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TextBoxCodePostal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ButtonValider = ((System.Windows.Controls.Button)(target));
            
            #line 76 "..\..\..\Vues\VilleWindow.xaml"
            this.ButtonValider.Click += new System.Windows.RoutedEventHandler(this.ButtonValider_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonCancel = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\Vues\VilleWindow.xaml"
            this.ButtonCancel.Click += new System.Windows.RoutedEventHandler(this.ButtonCancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

