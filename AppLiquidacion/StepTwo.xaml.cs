﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Windows.Media;

namespace AppLiquidacion
{
    public partial class StepTwo : PhoneApplicationPage
    {
        public static int YesOrNoPaySevenceAtTheTime;
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
                GridRecomendation.Visibility = Visibility.Collapsed;
                NoPaySeverence.IsChecked = false;
                YesOrNoPaySevenceAtTheTime = 1;
                YesPaySeverence.Foreground = new SolidColorBrush(Colors.Red);
                NoPaySeverence.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                YesOrNoPaySevenceAtTheTime = 0;
                YesPaySeverence.Foreground = new SolidColorBrush(Colors.White);
            }
        }

        private void NoPaySeverence_Click(object sender, RoutedEventArgs e)
        {
            if (NoPaySeverence.IsChecked == true)
            {
                GridNoPaySeverence.Visibility = Visibility.Visible;
                YesPaySeverence.IsChecked = false;
                YesOrNoPaySevenceAtTheTime = 2;
                NoPaySeverence.Foreground = new SolidColorBrush(Colors.Red);
                YesPaySeverence.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {  
                    YesOrNoPaySevenceAtTheTime = 0;
                GridNoPaySeverence.Visibility = Visibility.Collapsed;
                NoPaySeverence.Foreground = new SolidColorBrush(Colors.White);
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
                YesOwesVacations.Foreground = new SolidColorBrush(Colors.Red);
                NoOwesVacations.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                YesOrNoOwesVacations = 0;
                GridOwesVacations.Visibility = Visibility.Collapsed;
                YesOwesVacations.Foreground = new SolidColorBrush(Colors.White);
            }
        }

        private void NoOwesVacations_Click(object sender, RoutedEventArgs e)
        {
            if (NoOwesVacations.IsChecked == true)
            {
                YesOrNoOwesVacations = 2;
                GridOwesVacations.Visibility = Visibility.Collapsed;
                YesOwesVacations.IsChecked = false;
                NoOwesVacations.Foreground = new SolidColorBrush(Colors.Red);
                YesOwesVacations.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                YesOrNoOwesVacations = 0;
                NoOwesVacations.Foreground = new SolidColorBrush(Colors.White);
            }
        }

        private void Liquidate_Click(object sender, RoutedEventArgs e)
        {
            

            
            if (YesOrNoPaySevenceAtTheTime == 1)
                YesOrNoLiquidate += 1;
            if (YesOrNoPaySevenceAtTheTime == 2 && Days.SelectedIndex != -1 && Months.SelectedIndex != -1 && Years.SelectedIndex != -1)
                {
                     
                     ListBoxItem selectedYear = Years.SelectedItem as ListBoxItem;
                     int YearText = int.Parse(selectedYear.Content.ToString());
                     DayNoPaySeverence = new DateTime(YearText, Months.SelectedIndex + 1, Days.SelectedIndex + 1);
                     if (DayNoPaySeverence != null && DateTime.Now > DayNoPaySeverence && StepOne.DayStartWork <= DayNoPaySeverence)
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
            {
                MessageBox.Show("Hay algún campo sin rellenar o la fecha es invalida por una incoherencia en el teimpo.");
                YesOrNoLiquidate = 0;
            }
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
            if (DaysOwesVacations.Text != "" && !DaysOwesVacations.Text.Contains("-") && !DaysOwesVacations.Text.Contains(",") && DaysOwesVacations.Text.IndexOf(".") != 0)
            NumberDaysOwesVacations = Convert.ToInt64(DaysOwesVacations.Text);
            if (DaysOwesVacations.Text.IndexOf(".") == 0 || DaysOwesVacations.Text.IndexOf("-") == 0 || DaysOwesVacations.Text.IndexOf(",") == 0)
                DaysOwesVacations.Text = "";
            else
            {
                if (DaysOwesVacations.Text.Contains("-") || DaysOwesVacations.Text.Contains(","))
                    DaysOwesVacations.Text = DaysOwesVacations.Text.Substring(0, DaysOwesVacations.Text.IndexOf("-"));
            }

        }

        private void HelpOwesVacations_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Todos los empleados tienen 15 días habiles al año de vacaciones, si usted le debe algún día vacaciones a su empleado afectará el valor de la liquidación");
        }

        private void HelpPaySeverence_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Las cesantias son calculadas por el empleador todos los 30 de diciembre de cada año, y pueden ser cosgindas al fondo máximo al 14 de Febrero del siguiente año, si usted ha generado el proceso adecuadamente, seleccione Sí, de lo contrario seleccione No");
        }

        private void HelpPayNoSeverence_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Para este caso usted debe escoger la última fecha en la que pago la cesantías al trabajador, si nunca lo ha hecho, elija la fecha ed inicio del trabajador.");
        }

    }
}