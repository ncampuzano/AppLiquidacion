﻿#pragma checksum "C:\Users\campu_000\Desktop\AppLiquidacion\AppLiquidacion\FinalizedPayroll.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C38A33B55DD115F6DDB5A09F0A537E74"
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
    
    
    public partial class FinalizedPayroll : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBox EndValuePayroll;
        
        internal System.Windows.Controls.TextBlock Salary;
        
        internal System.Windows.Controls.TextBlock TransportSubsidy;
        
        internal System.Windows.Controls.TextBlock SalaryInKind;
        
        internal System.Windows.Controls.TextBlock Overtime;
        
        internal System.Windows.Controls.TextBlock Health;
        
        internal System.Windows.Controls.TextBlock Pension;
        
        internal System.Windows.Controls.TextBlock Solidarity;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppLiquidacion;component/FinalizedPayroll.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.EndValuePayroll = ((System.Windows.Controls.TextBox)(this.FindName("EndValuePayroll")));
            this.Salary = ((System.Windows.Controls.TextBlock)(this.FindName("Salary")));
            this.TransportSubsidy = ((System.Windows.Controls.TextBlock)(this.FindName("TransportSubsidy")));
            this.SalaryInKind = ((System.Windows.Controls.TextBlock)(this.FindName("SalaryInKind")));
            this.Overtime = ((System.Windows.Controls.TextBlock)(this.FindName("Overtime")));
            this.Health = ((System.Windows.Controls.TextBlock)(this.FindName("Health")));
            this.Pension = ((System.Windows.Controls.TextBlock)(this.FindName("Pension")));
            this.Solidarity = ((System.Windows.Controls.TextBlock)(this.FindName("Solidarity")));
        }
    }
}

