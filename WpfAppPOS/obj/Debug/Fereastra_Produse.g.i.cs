﻿#pragma checksum "..\..\Fereastra_Produse.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E1F626B1CE724ECC405BE8F05306BE3EAFE7B0DDF7617A082488D503CBC56DFF"
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
    /// Fereastra_Produse
    /// </summary>
    public partial class Fereastra_Produse : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\Fereastra_Produse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Fereastra_produse;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Fereastra_Produse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textbox_afisare_produse;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Fereastra_Produse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buton_afisarep;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Fereastra_Produse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buton_adaugap;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Fereastra_Produse.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button afisare_produsenoi;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfAppPOS;component/fereastra_produse.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Fereastra_Produse.xaml"
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
            this.Fereastra_produse = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.textbox_afisare_produse = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\Fereastra_Produse.xaml"
            this.textbox_afisare_produse.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.textbox_afisare_produse_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.buton_afisarep = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Fereastra_Produse.xaml"
            this.buton_afisarep.Click += new System.Windows.RoutedEventHandler(this.buton_afisarep_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buton_adaugap = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Fereastra_Produse.xaml"
            this.buton_adaugap.Click += new System.Windows.RoutedEventHandler(this.buton_adaugap_Click_1);
            
            #line default
            #line hidden
            return;
            case 5:
            this.afisare_produsenoi = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Fereastra_Produse.xaml"
            this.afisare_produsenoi.Click += new System.Windows.RoutedEventHandler(this.afisare_produsenoi_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

