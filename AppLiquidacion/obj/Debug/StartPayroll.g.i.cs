﻿#pragma checksum "C:\Users\campu_000\Desktop\AppLiquidacion\AppLiquidacion\StartPayroll.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9376EFCF9CF7C5CF5C5448CF348D4BB3"
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
    
    
    public partial class StartPayroll : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.CheckBox SalaryMonthly;
        
        internal System.Windows.Controls.CheckBox SalaryFortnightly;
        
        internal System.Windows.Controls.TextBox ValueSalary;
        
        internal System.Windows.Controls.Grid GridSalaryInKind;
        
        internal System.Windows.Controls.TextBlock TextSalaryInKind;
        
        internal System.Windows.Controls.CheckBox YesSalaryInKind;
        
        internal System.Windows.Controls.CheckBox NoSalaryInKind;
        
        internal System.Windows.Controls.Button HelpSalaryInKind;
        
        internal System.Windows.Controls.Grid GridYesSalaryInKind;
        
        internal System.Windows.Controls.TextBlock TextSalaryInKindAgreed;
        
        internal System.Windows.Controls.CheckBox YesSalaryInKindAgreed;
        
        internal System.Windows.Controls.CheckBox NoSalaryInKindAgreed;
        
        internal System.Windows.Controls.Grid GridYesSalaryInKindAgreed;
        
        internal System.Windows.Controls.TextBlock TextHowManyIsSalaryInKind;
        
        internal System.Windows.Controls.TextBox HowManyIsSalaryInKind;
        
        internal System.Windows.Controls.TextBox HoursWorkedInWeek;
        
        internal System.Windows.Controls.CheckBox YesOvertime;
        
        internal System.Windows.Controls.CheckBox NoOvertime;
        
        internal System.Windows.Controls.Grid GridTableOfHours;
        
        internal System.Windows.Controls.TextBox OvertimeSundayInDay;
        
        internal System.Windows.Controls.TextBox OvertimeWeekInDay;
        
        internal System.Windows.Controls.TextBox OvertimeWeekAtNight;
        
        internal System.Windows.Controls.TextBox OvertimeSundayAtNight;
        
        internal System.Windows.Controls.Button Finalized;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/AppLiquidacion;component/StartPayroll.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.SalaryMonthly = ((System.Windows.Controls.CheckBox)(this.FindName("SalaryMonthly")));
            this.SalaryFortnightly = ((System.Windows.Controls.CheckBox)(this.FindName("SalaryFortnightly")));
            this.ValueSalary = ((System.Windows.Controls.TextBox)(this.FindName("ValueSalary")));
            this.GridSalaryInKind = ((System.Windows.Controls.Grid)(this.FindName("GridSalaryInKind")));
            this.TextSalaryInKind = ((System.Windows.Controls.TextBlock)(this.FindName("TextSalaryInKind")));
            this.YesSalaryInKind = ((System.Windows.Controls.CheckBox)(this.FindName("YesSalaryInKind")));
            this.NoSalaryInKind = ((System.Windows.Controls.CheckBox)(this.FindName("NoSalaryInKind")));
            this.HelpSalaryInKind = ((System.Windows.Controls.Button)(this.FindName("HelpSalaryInKind")));
            this.GridYesSalaryInKind = ((System.Windows.Controls.Grid)(this.FindName("GridYesSalaryInKind")));
            this.TextSalaryInKindAgreed = ((System.Windows.Controls.TextBlock)(this.FindName("TextSalaryInKindAgreed")));
            this.YesSalaryInKindAgreed = ((System.Windows.Controls.CheckBox)(this.FindName("YesSalaryInKindAgreed")));
            this.NoSalaryInKindAgreed = ((System.Windows.Controls.CheckBox)(this.FindName("NoSalaryInKindAgreed")));
            this.GridYesSalaryInKindAgreed = ((System.Windows.Controls.Grid)(this.FindName("GridYesSalaryInKindAgreed")));
            this.TextHowManyIsSalaryInKind = ((System.Windows.Controls.TextBlock)(this.FindName("TextHowManyIsSalaryInKind")));
            this.HowManyIsSalaryInKind = ((System.Windows.Controls.TextBox)(this.FindName("HowManyIsSalaryInKind")));
            this.HoursWorkedInWeek = ((System.Windows.Controls.TextBox)(this.FindName("HoursWorkedInWeek")));
            this.YesOvertime = ((System.Windows.Controls.CheckBox)(this.FindName("YesOvertime")));
            this.NoOvertime = ((System.Windows.Controls.CheckBox)(this.FindName("NoOvertime")));
            this.GridTableOfHours = ((System.Windows.Controls.Grid)(this.FindName("GridTableOfHours")));
            this.OvertimeSundayInDay = ((System.Windows.Controls.TextBox)(this.FindName("OvertimeSundayInDay")));
            this.OvertimeWeekInDay = ((System.Windows.Controls.TextBox)(this.FindName("OvertimeWeekInDay")));
            this.OvertimeWeekAtNight = ((System.Windows.Controls.TextBox)(this.FindName("OvertimeWeekAtNight")));
            this.OvertimeSundayAtNight = ((System.Windows.Controls.TextBox)(this.FindName("OvertimeSundayAtNight")));
            this.Finalized = ((System.Windows.Controls.Button)(this.FindName("Finalized")));
        }
    }
}
