﻿#pragma checksum "C:\Users\campu_000\Desktop\AppLiquidacion\AppLiquidacion\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9CAAE1B27C5BDB1DAF02F7C54B6A6BAF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace AppLiquidacion {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock Information;
        
        internal System.Windows.Controls.TextBlock TextDataWorker;
        
        internal System.Windows.Controls.TextBox BoxNameWorker;
        
        internal System.Windows.Controls.TextBlock TextName;
        
        internal System.Windows.Controls.TextBlock TextIdentification;
        
        internal System.Windows.Controls.TextBox IdentificationWorker;
        
        internal System.Windows.Controls.Button Comenzar;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppLiquidacion;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Information = ((System.Windows.Controls.TextBlock)(this.FindName("Information")));
            this.TextDataWorker = ((System.Windows.Controls.TextBlock)(this.FindName("TextDataWorker")));
            this.BoxNameWorker = ((System.Windows.Controls.TextBox)(this.FindName("BoxNameWorker")));
            this.TextName = ((System.Windows.Controls.TextBlock)(this.FindName("TextName")));
            this.TextIdentification = ((System.Windows.Controls.TextBlock)(this.FindName("TextIdentification")));
            this.IdentificationWorker = ((System.Windows.Controls.TextBox)(this.FindName("IdentificationWorker")));
            this.Comenzar = ((System.Windows.Controls.Button)(this.FindName("Comenzar")));
        }
    }
}
