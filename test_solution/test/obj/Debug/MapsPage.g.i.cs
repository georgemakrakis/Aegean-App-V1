﻿#pragma checksum "C:\Users\argir\Documents\Visual Studio 2013\Projects\test_solution\test\MapsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E6CFC61EB2700C33A09F4C3F381925ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Maps.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace aegeanapp {
    
    
    public partial class MapsPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.ListPicker Listpicker;
        
        internal Microsoft.Phone.Maps.Controls.Map maploc;
        
        internal System.Windows.Controls.Button Locate_Btn;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/aegeanapp;component/MapsPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Listpicker = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("Listpicker")));
            this.maploc = ((Microsoft.Phone.Maps.Controls.Map)(this.FindName("maploc")));
            this.Locate_Btn = ((System.Windows.Controls.Button)(this.FindName("Locate_Btn")));
        }
    }
}

