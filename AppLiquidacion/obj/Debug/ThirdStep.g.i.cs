﻿#pragma checksum "C:\Users\campu_000\Desktop\AppLiquidacion\AppLiquidacion\ThirdStep.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4407151DA700D2D6CB9E683E37E8ADAA"
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
    
    
    public partial class ThirdStep : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock TextLiquidate;
        
        internal System.Windows.Controls.TextBox ValueLiquidateNumber;
        
        internal System.Windows.Controls.TextBlock DataOfWorker;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppLiquidacion;component/ThirdStep.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.TextLiquidate = ((System.Windows.Controls.TextBlock)(this.FindName("TextLiquidate")));
            this.ValueLiquidateNumber = ((System.Windows.Controls.TextBox)(this.FindName("ValueLiquidateNumber")));
            this.DataOfWorker = ((System.Windows.Controls.TextBlock)(this.FindName("DataOfWorker")));
        }
    }
}

