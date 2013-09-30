using System;
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
    public partial class StepOne : PhoneApplicationPage
    {
        // None = 0 Yes = 1 No = 2
        // MonthsChangedSalary  = 0 ,= 1, = 2 or = 3
        public static int GoodFired;
        public static int YesOrNoSalaryChanged;
        public static int YesOrNoSalaryInKind;
        public static int YesOrNoSalaryInKindAgreed;
        public static DateTime DayStartWork = new DateTime();
        public static DateTime DayEndWork = new DateTime();
        public static int MonthsChangedSalary;
        public static float  ActualSalary;
        public static int ValueTransportationSubsidary = 72500;
        public static float ValueOldSalary;
        public static float ValuePayInKind = 0;

        public string ValueWithinPoints(string NumberWithPoints)
        {
            string ObjectNumber = "";
            string[] Segments = NumberWithPoints.Split(',');
            foreach (string i in Segments)
            {
                ObjectNumber = ObjectNumber + i;
            }
            return ObjectNumber;
        }
        public string ValueWithPoints(string Number)
        {
            string ObjectNumber = "";
            string[] Segments = Number.Split(',');
            foreach (string i in Segments)
            {
                ObjectNumber = ObjectNumber + i;
            }

            var NumberWithPoints = String.Format("{0:#,0}", Convert.ToInt64(ObjectNumber));
            return NumberWithPoints;
        }
        public StepOne()
        {
            InitializeComponent();

        }
        private void YesChangedSalary_Click(object sender, RoutedEventArgs e)
        {
            if (YesChangedSalary.IsChecked == true)
            {
                NoChangedSalary.IsChecked = false;
                GridChangedSalary.Visibility = Visibility.Visible;
                YesOrNoSalaryChanged = 1;
            }
            else
            {
                GridChangedSalary.Visibility = Visibility.Collapsed;
                YesOrNoSalaryChanged = 0;
            }
        }

        private void NoChangedSalary_Click(object sender, RoutedEventArgs e)
        {
            if (NoChangedSalary.IsChecked == true)
            {
                YesChangedSalary.IsChecked = false;
                GridChangedSalary.Visibility = Visibility.Collapsed;
                YesOrNoSalaryChanged = 2;
            }
            else
                YesOrNoSalaryChanged = 0;
        }       
        private void YesSalaryInKind_Click(object sender, RoutedEventArgs e)
        {
            if (YesSalaryInKind.IsChecked == true)
            {
                GridYesSalaryInKind.Visibility = Visibility.Visible;
                YesOrNoSalaryInKind = 1;
                NoSalaryInKind.IsChecked = false;
            }
            else
            {
                GridYesSalaryInKind.Visibility = Visibility.Collapsed;
                YesOrNoSalaryInKind = 0;
            }
                
        }

        private void NoSalaryInKind_Click(object sender, RoutedEventArgs e)
        {
            if (NoSalaryInKind.IsChecked == true)
            {
                GridYesSalaryInKind.Visibility = Visibility.Collapsed;
                YesOrNoSalaryInKind = 2;
                YesSalaryInKind.IsChecked = false;
                GridYesSalaryInKindAgreed.Visibility = Visibility.Collapsed;
            }
            else
                YesOrNoSalaryInKind = 0;
        }

        private void YesSalaryInKindAgreed_Click(object sender, RoutedEventArgs e)
        {
            if (YesSalaryInKindAgreed.IsChecked == true)
            {
                GridYesSalaryInKindAgreed.Visibility = Visibility.Visible;
                YesOrNoSalaryInKindAgreed = 1;
                NoSalaryInKindAgreed.IsChecked = false;
            }
            else
            {
                GridYesSalaryInKindAgreed.Visibility = Visibility.Collapsed;
                YesOrNoSalaryInKindAgreed = 0;
            }
        }

        private void NoSalaryInKindAgreed_Click(object sender, RoutedEventArgs e)
        {
            if (NoSalaryInKindAgreed.IsChecked == true)
            {
                GridYesSalaryInKindAgreed.Visibility = Visibility.Collapsed;
                YesOrNoSalaryInKindAgreed = 2;
                YesSalaryInKindAgreed.IsChecked = false;
            }
            else
                YesOrNoSalaryInKindAgreed = 0;     
        }

        private void StepTwo_Click(object sender, RoutedEventArgs e)
        {

            if (StartDays.SelectedIndex != -1 && StartMonths.SelectedIndex != -1 && StartYears.SelectedIndex != -1)
            {
                ListBoxItem selectedYear = StartYears.SelectedItem as ListBoxItem;
                int StartYearText = int.Parse(selectedYear.Content.ToString());
                DayStartWork = new DateTime(StartYearText, (StartMonths.SelectedIndex + 1), (StartDays.SelectedIndex + 1));
            }
            if (EndDays.SelectedIndex != -1 && EndMonths.SelectedIndex != -1 && EndYears.SelectedIndex != -1)
            {
                ListBoxItem selectedEndYear = EndYears.SelectedItem as ListBoxItem;
                int EndYearText = int.Parse(selectedEndYear.Content.ToString());
                DayEndWork = new DateTime(EndYearText ,(EndMonths.SelectedIndex + 1), (EndDays.SelectedIndex + 1));
            }
            
            int YesOrNoTwoStep = 0;
            double NumberMonthssWorked = StepOne.DayEndWork.Subtract(StepOne.DayStartWork).TotalDays / 30;
           if (DayStartWork != null && DateTime.Now > DayStartWork)
                YesOrNoTwoStep += 1;
           if (DayEndWork != null && DayEndWork > DayStartWork && DateTime.Now >= DayEndWork )
                YesOrNoTwoStep += 1;
           if (Salary.Text != "")
                YesOrNoTwoStep += 1;
           if (GoodFired == 1 || GoodFired == 2)
                YesOrNoTwoStep += 1;
           if (YesOrNoSalaryChanged == 2)
                YesOrNoTwoStep += 1;
           if (YesOrNoSalaryChanged == 1)
           {
               if ((MonthsChangedSalary == 1 || MonthsChangedSalary == 2 || MonthsChangedSalary == 3) && OldSalary.Text != "")
               {
                   if (MonthsChangedSalary == 1 && NumberMonthssWorked > 1)
                       YesOrNoTwoStep += 1;
                   if (MonthsChangedSalary == 2 && NumberMonthssWorked > 2)
                       YesOrNoTwoStep += 1;
                   if (MonthsChangedSalary == 3 && NumberMonthssWorked > 3)
                       YesOrNoTwoStep += 1;
               }
           }
           if (YesOrNoSalaryInKind == 2)
               YesOrNoTwoStep += 1;
           if (YesOrNoSalaryInKind == 1)
           {
               if (YesOrNoSalaryInKindAgreed == 1 && HowManyIsSalaryInKind.Text != "")
                   YesOrNoTwoStep += 1;
               if (YesOrNoSalaryInKindAgreed == 2)
                   YesOrNoTwoStep += 1;
           }



           if (YesOrNoTwoStep == 6)
           {
               NavigationService.Navigate(new Uri("/StepTwo.xaml", UriKind.Relative));
               YesOrNoTwoStep = 0;
           }
           else
           {
               GridHumanStupid.Visibility = Visibility.Visible;
               YesOrNoTwoStep = 0;
           }

        }

        

        private void OneMonthChanged_Click(object sender, RoutedEventArgs e)
        {
            if (OneMonthChanged.IsChecked == true)
            {
                TwoMonthChanged.IsChecked = false;
                ThreeMonthChanged.IsChecked = false;
                MonthsChangedSalary = 1;
            }
            else
                MonthsChangedSalary = 0;
        }

        private void TwoMonthChanged_Click(object sender, RoutedEventArgs e)
        {
            if (TwoMonthChanged.IsChecked == true)
            {
                OneMonthChanged.IsChecked = false;
                ThreeMonthChanged.IsChecked = false;
                MonthsChangedSalary = 2;
            }
            else
                MonthsChangedSalary = 0;
        }

        private void ThreeMonthChanged_Click(object sender, RoutedEventArgs e)
        {
            if (ThreeMonthChanged.IsChecked == true)
            {
                OneMonthChanged.IsChecked = false;
                TwoMonthChanged.IsChecked = false;
                MonthsChangedSalary = 3;
            }
            else
                MonthsChangedSalary = 0;
        }

        private void Salary_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

            if (e.PlatformKeyCode == 190)
            {
                e.Handled = true;
            }
              
        }

        private void OldSalary_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.PlatformKeyCode == 190)
                {
                    e.Handled = true;
                }
        }

        private void HowManyIsSalaryInKind_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.PlatformKeyCode == 190)
            {
                e.Handled = true;
            }
        }

        private void ThreeMonthChanged_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.PlatformKeyCode == 190)
            {
                e.Handled = true;
            }
        }
        private void HowManyIsSalaryInKind_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if(HowManyIsSalaryInKind.Text.Length > 3)
            HowManyIsSalaryInKind.Text = ValueWithPoints(HowManyIsSalaryInKind.Text);
            HowManyIsSalaryInKind.Select(HowManyIsSalaryInKind.Text.Length, 0);
            if (HowManyIsSalaryInKind.Text != "")
            ValuePayInKind = Convert.ToInt64(ValueWithinPoints(HowManyIsSalaryInKind.Text));
            

        }

        private void OldSalary_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OldSalary.Text.Length > 3)
                OldSalary.Text = ValueWithPoints(OldSalary.Text);
            OldSalary.Select(OldSalary.Text.Length, 0);
            if (OldSalary.Text != "")
                ValueOldSalary = Convert.ToInt64(ValueWithinPoints(OldSalary.Text));
            
        }

        private void Resign_Click(object sender, RoutedEventArgs e)
        {
            if (Resign.IsChecked == true)
            {
                Fired.IsChecked = false;
                GoodFired = 1;
                GridGoodFiredOrNot.Visibility = Visibility.Collapsed;
            }
            else
                GoodFired = 2;

        }

        private void Fired_Click(object sender, RoutedEventArgs e)
        {
            if (Fired.IsChecked == true)
            {
                Resign.IsChecked = false;
                GridGoodFiredOrNot.Visibility = Visibility.Visible;
            }
            else
            {
                GoodFired = 0;
                GridGoodFiredOrNot.Visibility = Visibility.Collapsed;
            }
        }

        private void YesFiredJust_Click(object sender, RoutedEventArgs e)
        {
            if (YesFiredJust.IsChecked == true)
            {
                NoFiredJust.IsChecked = false;
                GoodFired = 1;
            }
            else
                GoodFired = 0;
        }

        private void NoFiredJust_Click(object sender, RoutedEventArgs e)
        {
            if (NoFiredJust.IsChecked == true)
            {
                YesFiredJust.IsChecked = false;
                GoodFired = 2;
            }
            else
                GoodFired = 0;
        }

        private void HelpSalaryInKind_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("El salario en especie hace referencia a un pago que no sea monetario, por ejemplo alimentación, ropa, entre otros");
        }

        private void HelpChangedSalary_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Si ha habido un cambio dentro en el salario con respecto a los últimos tres meses, el valor de la liquidación cambiará");
        }

        private void HelpFired_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Cuando el despido fue con causa injusta el empleado debe recibir una indemnización,  por lo cual cambia el valor de la liquidación");
        }

        private void Salary_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Salary.Text.Length > 3)
                Salary.Text = ValueWithPoints(Salary.Text);
            Salary.Select(Salary.Text.Length, 0);
            if (Salary.Text != "")
                ActualSalary = Convert.ToInt64(ValueWithinPoints(Salary.Text));
        }


       
    }
}