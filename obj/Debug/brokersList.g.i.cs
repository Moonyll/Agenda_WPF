﻿#pragma checksum "..\..\brokersList.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C7E1647911B8A22BE7C850E167EEACDC9DE1B113"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Agenda_WPF;
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


namespace Agenda_WPF {
    
    
    /// <summary>
    /// brokersList
    /// </summary>
    public partial class brokersList : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\brokersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid listing_brok;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\brokersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastName;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\brokersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\brokersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Mail;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\brokersList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneNumber;
        
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
            System.Uri resourceLocater = new System.Uri("/Agenda_WPF;component/brokerslist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\brokersList.xaml"
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
            
            #line 9 "..\..\brokersList.xaml"
            ((Agenda_WPF.brokersList)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Broker_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listing_brok = ((System.Windows.Controls.DataGrid)(target));
            
            #line 20 "..\..\brokersList.xaml"
            this.listing_brok.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.Details);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.FirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Mail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PhoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 62 "..\..\brokersList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DelBrok);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 63 "..\..\brokersList.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateBrok);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
