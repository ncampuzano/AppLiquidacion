﻿#pragma checksum "C:\Users\campu_000\Desktop\AppLiquidacion\AppLiquidacion\StepOne.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "75A85C46CDD1977FB1F17AA082A5B3B1"
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
    
    
    public partial class StepOne : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock AppName;
        
        internal System.Windows.Controls.TextBlock Step1;
        
        internal System.Windows.Controls.ListBox StartDays;
        
        internal System.Windows.Controls.ListBox StartMonths;
        
        internal System.Windows.Controls.ListBox StartYears;
        
        internal System.Windows.Controls.TextBlock TextStartWork;
        
        internal System.Windows.Controls.ListBox EndDays;
        
        internal System.Windows.Controls.ListBox EndMonths;
        
        internal System.Windows.Controls.ListBox EndYears;
        
        internal System.Windows.Controls.TextBlock TextEndWork;
        
        internal System.Windows.Controls.TextBlock TextSalary;
        
        internal System.Windows.Controls.TextBox Salary;
        
        internal System.Windows.Controls.Grid GridTransportSubsidy;
        
        internal System.Windows.Controls.TextBlock TextTransportSubsidy;
        
        internal System.Windows.Controls.TextBox TransportSubsidy;
        
        internal System.Windows.Controls.Grid GridSalary;
        
        internal System.Windows.Controls.TextBlock TextChangeSalary;
        
        internal System.Windows.Controls.CheckBox YesChangedSalary;
        
        internal System.Windows.Controls.CheckBox NoChangedSalary;
        
        internal System.Windows.Controls.Grid GridChangedSalary;
        
        internal System.Windows.Controls.TextBlock TextTimeOfChange;
        
        internal System.Windows.Controls.TextBlock TextOldSalary;
        
        internal System.Windows.Controls.TextBox OldSalary;
        
        internal System.Windows.Controls.CheckBox OneMonthChanged;
        
        internal System.Windows.Controls.CheckBox TwoMonthChanged;
        
        internal System.Windows.Controls.CheckBox ThreeMonthChanged;
        
        internal System.Windows.Controls.Grid GridFiredJust;
        
        internal System.Windows.Controls.TextBlock TextFiredJust;
        
        internal System.Windows.Controls.CheckBox YesFiredJust;
        
        internal System.Windows.Controls.CheckBox NoFiredJust;
        
        internal System.Windows.Controls.Grid GridSalaryInKind;
        
        internal System.Windows.Controls.TextBlock TextSalaryInKind;
        
        internal System.Windows.Controls.CheckBox YesSalaryInKind;
        
        internal System.Windows.Controls.CheckBox NoSalaryInKind;
        
        internal System.Windows.Controls.Grid GridYesSalaryInKind;
        
        internal System.Windows.Controls.TextBlock TextSalaryInKindAgreed;
        
        internal System.Windows.Controls.CheckBox YesSalaryInKindAgreed;
        
        internal System.Windows.Controls.CheckBox NoSalaryInKindAgreed;
        
        internal System.Windows.Controls.Grid GridYesSalaryInKindAgreed;
        
        internal System.Windows.Controls.TextBlock TextHowManyIsSalaryInKind;
        
        internal System.Windows.Controls.TextBox HowManyIsSalaryInKind;
        
        internal System.Windows.Controls.Grid GridStepTwo;
        
        internal System.Windows.Controls.Button StepTwo;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppLiquidacion;component/StepOne.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.AppName = ((System.Windows.Controls.TextBlock)(this.FindName("AppName")));
            this.Step1 = ((System.Windows.Controls.TextBlock)(this.FindName("Step1")));
            this.StartDays = ((System.Windows.Controls.ListBox)(this.FindName("StartDays")));
            this.StartMonths = ((System.Windows.Controls.ListBox)(this.FindName("StartMonths")));
            this.StartYears = ((System.Windows.Controls.ListBox)(this.FindName("StartYears")));
            this.TextStartWork = ((System.Windows.Controls.TextBlock)(this.FindName("TextStartWork")));
            this.EndDays = ((System.Windows.Controls.ListBox)(this.FindName("EndDays")));
            this.EndMonths = ((System.Windows.Controls.ListBox)(this.FindName("EndMonths")));
            this.EndYears = ((System.Windows.Controls.ListBox)(this.FindName("EndYears")));
            this.TextEndWork = ((System.Windows.Controls.TextBlock)(this.FindName("TextEndWork")));
            this.TextSalary = ((System.Windows.Controls.TextBlock)(this.FindName("TextSalary")));
            this.Salary = ((System.Windows.Controls.TextBox)(this.FindName("Salary")));
            this.GridTransportSubsidy = ((System.Windows.Controls.Grid)(this.FindName("GridTransportSubsidy")));
            this.TextTransportSubsidy = ((System.Windows.Controls.TextBlock)(this.FindName("TextTransportSubsidy")));
            this.TransportSubsidy = ((System.Windows.Controls.TextBox)(this.FindName("TransportSubsidy")));
            this.GridSalary = ((System.Windows.Controls.Grid)(this.FindName("GridSalary")));
            this.TextChangeSalary = ((System.Windows.Controls.TextBlock)(this.FindName("TextChangeSalary")));
            this.YesChangedSalary = ((System.Windows.Controls.CheckBox)(this.FindName("YesChangedSalary")));
            this.NoChangedSalary = ((System.Windows.Controls.CheckBox)(this.FindName("NoChangedSalary")));
            this.GridChangedSalary = ((System.Windows.Controls.Grid)(this.FindName("GridChangedSalary")));
            this.TextTimeOfChange = ((System.Windows.Controls.TextBlock)(this.FindName("TextTimeOfChange")));
            this.TextOldSalary = ((System.Windows.Controls.TextBlock)(this.FindName("TextOldSalary")));
            this.OldSalary = ((System.Windows.Controls.TextBox)(this.FindName("OldSalary")));
            this.OneMonthChanged = ((System.Windows.Controls.CheckBox)(this.FindName("OneMonthChanged")));
            this.TwoMonthChanged = ((System.Windows.Controls.CheckBox)(this.FindName("TwoMonthChanged")));
            this.ThreeMonthChanged = ((System.Windows.Controls.CheckBox)(this.FindName("ThreeMonthChanged")));
            this.GridFiredJust = ((System.Windows.Controls.Grid)(this.FindName("GridFiredJust")));
            this.TextFiredJust = ((System.Windows.Controls.TextBlock)(this.FindName("TextFiredJust")));
            this.YesFiredJust = ((System.Windows.Controls.CheckBox)(this.FindName("YesFiredJust")));
            this.NoFiredJust = ((System.Windows.Controls.CheckBox)(this.FindName("NoFiredJust")));
            this.GridSalaryInKind = ((System.Windows.Controls.Grid)(this.FindName("GridSalaryInKind")));
            this.TextSalaryInKind = ((System.Windows.Controls.TextBlock)(this.FindName("TextSalaryInKind")));
            this.YesSalaryInKind = ((System.Windows.Controls.CheckBox)(this.FindName("YesSalaryInKind")));
            this.NoSalaryInKind = ((System.Windows.Controls.CheckBox)(this.FindName("NoSalaryInKind")));
            this.GridYesSalaryInKind = ((System.Windows.Controls.Grid)(this.FindName("GridYesSalaryInKind")));
            this.TextSalaryInKindAgreed = ((System.Windows.Controls.TextBlock)(this.FindName("TextSalaryInKindAgreed")));
            this.YesSalaryInKindAgreed = ((System.Windows.Controls.CheckBox)(this.FindName("YesSalaryInKindAgreed")));
            this.NoSalaryInKindAgreed = ((System.Windows.Controls.CheckBox)(this.FindName("NoSalaryInKindAgreed")));
            this.GridYesSalaryInKindAgreed = ((System.Windows.Controls.Grid)(this.FindName("GridYesSalaryInKindAgreed")));
            this.TextHowManyIsSalaryInKind = ((System.Windows.Controls.TextBlock)(this.FindName("TextHowManyIsSalaryInKind")));
            this.HowManyIsSalaryInKind = ((System.Windows.Controls.TextBox)(this.FindName("HowManyIsSalaryInKind")));
            this.GridStepTwo = ((System.Windows.Controls.Grid)(this.FindName("GridStepTwo")));
            this.StepTwo = ((System.Windows.Controls.Button)(this.FindName("StepTwo")));
        }
    }
}

