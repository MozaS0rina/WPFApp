﻿#pragma checksum "..\..\Servicii_tastatura.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EBE00D24A3229E38C66097192C4ADCAE5ACC896E010FD984AC195D276E14B561"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
using WpfAppPOS;


namespace WpfAppPOS {
    
    
    /// <summary>
    /// Servicii_tastatura
    /// </summary>
    public partial class Servicii_tastatura : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Servicii_tastatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfAppPOS.Servicii_tastatura servicii_tastatura;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Servicii_tastatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid servicii_tastatura1;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Servicii_tastatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buton_adauga;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Servicii_tastatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_nume;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Servicii_tastatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_cod;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Servicii_tastatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_categorie;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Servicii_tastatura.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_pret;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppPOS;component/servicii_tastatura.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Servicii_tastatura.xaml"
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
            this.servicii_tastatura = ((WpfAppPOS.Servicii_tastatura)(target));
            return;
            case 2:
            this.servicii_tastatura1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.buton_adauga = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Servicii_tastatura.xaml"
            this.buton_adauga.Click += new System.Windows.RoutedEventHandler(this.buton_adauga_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textbox_nume = ((System.Windows.Controls.TextBox)(target));
            
            #line 18 "..\..\Servicii_tastatura.xaml"
            this.textbox_nume.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textbox_nume_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.textbox_cod = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.textbox_categorie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.textbox_pret = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

