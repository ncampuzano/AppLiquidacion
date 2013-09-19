﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace AppLiquidacion
{
    public partial class StepTwo : PhoneApplicationPage
    {
        public static int YesOrNoPaySerenceAtTheTime;
        public static int YesOrNoOwesVacations;
        public static int YesOrNoLiquidate;
        public static DateTime DayNoPaySeverence = new DateTime();
        public static long NumberDaysOwesVacations;

        public StepTwo()
        {
            InitializeComponent();
        }

        private void YesPaySeverence_Click(object sender, RoutedEventArgs e)
        {
            if (YesPaySeverence.IsChecked == true)
            {
                GridNoPaySeverence.Visibility = Visibility.Collapsed;
                NoPaySeverence.IsChecked = false;
                YesOrNoPaySerenceAtTheTime = 1;
            }
        }

        private void NoPaySeverence_Click(object sender, RoutedEventArgs e)
        {
            if (NoPaySeverence.IsChecked == true)
            {
                GridNoPaySeverence.Visibility = Visibility.Visible;
                YesPaySeverence.IsChecked = false;
                YesOrNoPaySerenceAtTheTime = 2;
            }
            else
            {  
                    YesOrNoPaySerenceAtTheTime = 0;
                GridNoPaySeverence.Visibility = Visibility.Collapsed;
            }

        }

        private void Recomendation_Click(object sender, RoutedEventArgs e)
        {
            if (GridRecomendation.Visibility == Visibility.Collapsed)
            {
                GridRecomendation.Visibility = Visibility.Visible;
            }
            else
            {
                GridRecomendation.Visibility = Visibility.Collapsed;
            }
        }

        private void YesOwesVacations_Click(object sender, RoutedEventArgs e)
        {
            if (YesOwesVacations.IsChecked == true)
            {
                NoOwesVacations.IsChecked = false;
                GridOwesVacations.Visibility = Visibility.Visible;
                YesOrNoOwesVacations = 1;
            }
            else
            {
                YesOrNoOwesVacations = 0;
                GridOwesVacations.Visibility = Visibility.Collapsed;
            }
        }

        private void NoOwesVacations_Click(object sender, RoutedEventArgs e)
        {
            if (NoOwesVacations.IsChecked == true)
            {
                YesOrNoOwesVacations = 2;
                GridOwesVacations.Visibility = Visibility.Collapsed;
                YesOwesVacations.IsChecked = false;
            }
            else
                YesOrNoOwesVacations = 0;
        }

        private void Liquidate_Click(object sender, RoutedEventArgs e)
        {
            

            
            if (YesOrNoPaySerenceAtTheTime == 1)
                YesOrNoLiquidate += 1;
            if (YesOrNoPaySerenceAtTheTime == 2 && Days.SelectedIndex != -1 && Months.SelectedIndex != -1 && Years.SelectedIndex != -1)
                {
                     
                     ListBoxItem selectedYear = Years.SelectedItem as ListBoxItem;
                     int YearText = int.Parse(selectedYear.Content.ToString());
                     DayNoPaySeverence = new DateTime(YearText, Months.SelectedIndex + 1, Days.SelectedIndex + 1);
                     if (DayNoPaySeverence != null && DateTime.Now > DayNoPaySeverence)
                        YesOrNoLiquidate += 1;
                }
            if (YesOrNoOwesVacations == 1 && DaysOwesVacations.Text != "")
                YesOrNoLiquidate += 1;
            if (YesOrNoOwesVacations == 2)
                YesOrNoLiquidate += 1;

            if (YesOrNoLiquidate == 2)
            {
                NavigationService.Navigate(new Uri("/ThirdStep.xaml", UriKind.Relative));
                YesOrNoLiquidate = 0;
            }
            else
                GridHumanStupid.Visibility = Visibility.Visible;
        }

        private void DaysOwesVacations_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.PlatformKeyCode == 190)
            {
                e.Handled = true;
            }
        }

        private void DaysOwesVacations_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DaysOwesVacations.Text != "")
            NumberDaysOwesVacations = Convert.ToInt64(DaysOwesVacations.Text);
        }
    }
}