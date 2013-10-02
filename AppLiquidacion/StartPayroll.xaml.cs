using System;
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
    public partial class StartPayroll : PhoneApplicationPage
    {
        public static short MonthlyOrFortnightly;
        public static short YesOrNoSalaryInKindAgreed;
        public static short YesOrNoSalaryInKind;
        public static short YesOrNoOvertime;
        public static short YesOrNoFinalized = 2;
        public static long ValueSalaryActual;
        public static int ValueHoursWorkedInWeek;
        public static long ValueHowManyIsSalaryInKind;
        public static int ValueOvertimeSundayInDay;
        public static int ValueOvertimeSundayAtNight;
        public static int ValueOvertimeWeekAtNight;
        public static int ValueOvertimeWeekInDay;
        // Constructor
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
        public StartPayroll()
        {
            InitializeComponent();            
        }

        private void SalaryMonthly_Click(object sender, RoutedEventArgs e)
        {
            if (SalaryMonthly.IsChecked == true)
            {
                SalaryFortnightly.IsChecked = false;
                MonthlyOrFortnightly = 1;
                SalaryMonthly.Foreground = new SolidColorBrush(Colors.Red);
                SalaryFortnightly.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                MonthlyOrFortnightly = 0;
                SalaryMonthly.Foreground = new SolidColorBrush(Colors.White);
            }
        }   

        private void SalaryFortnightly_Click(object sender, RoutedEventArgs e)
        {
            if (SalaryFortnightly.IsChecked == true)
            {
                SalaryMonthly.IsChecked = false;
                MonthlyOrFortnightly = 2;
                SalaryFortnightly.Foreground = new SolidColorBrush(Colors.Red);
                SalaryMonthly.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                MonthlyOrFortnightly = 0;
                SalaryFortnightly.Foreground = new SolidColorBrush(Colors.White);
            }
        }
        private void YesSalaryInKindAgreed_Click(object sender, RoutedEventArgs e)
        {
            if (YesSalaryInKindAgreed.IsChecked == true)
            {
                GridYesSalaryInKindAgreed.Visibility = Visibility.Visible;
                YesOrNoSalaryInKindAgreed = 1;
                NoSalaryInKindAgreed.IsChecked = false;
                YesSalaryInKindAgreed.Foreground = new SolidColorBrush(Colors.Red);
                NoSalaryInKindAgreed.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                GridYesSalaryInKindAgreed.Visibility = Visibility.Collapsed;
                YesOrNoSalaryInKindAgreed = 0;
                YesSalaryInKindAgreed.Foreground = new SolidColorBrush(Colors.White);
            }
        }

        private void NoSalaryInKindAgreed_Click(object sender, RoutedEventArgs e)
        {
            if (NoSalaryInKindAgreed.IsChecked == true)
            {
                GridYesSalaryInKindAgreed.Visibility = Visibility.Collapsed;
                YesOrNoSalaryInKindAgreed = 2;
                YesSalaryInKindAgreed.IsChecked = false;
                NoSalaryInKindAgreed.Foreground = new SolidColorBrush(Colors.Red);
                YesSalaryInKindAgreed.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                YesOrNoSalaryInKindAgreed = 0;
                NoSalaryInKindAgreed.Foreground = new SolidColorBrush(Colors.White);
            }
        }
        private void YesSalaryInKind_Click(object sender, RoutedEventArgs e)
        {
            if (YesSalaryInKind.IsChecked == true)
            {
                GridYesSalaryInKind.Visibility = Visibility.Visible;
                YesOrNoSalaryInKind = 1;
                NoSalaryInKind.IsChecked = false;
                YesSalaryInKind.Foreground = new SolidColorBrush(Colors.Red);
                NoSalaryInKind.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                GridYesSalaryInKind.Visibility = Visibility.Collapsed;
                YesOrNoSalaryInKind = 0;
                YesSalaryInKind.Foreground = new SolidColorBrush(Colors.White);
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
                NoSalaryInKind.Foreground = new SolidColorBrush(Colors.Red);
                YesSalaryInKind.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                YesOrNoSalaryInKind = 0;
                NoSalaryInKind.Foreground = new SolidColorBrush(Colors.White);
            }

        }

        private void YesOvertime_Click(object sender, RoutedEventArgs e)
        {
            if (YesOvertime.IsChecked == true)
            {
                NoOvertime.IsChecked = false;
                YesOrNoOvertime = 1;
                GridTableOfHours.Visibility = Visibility.Visible;
                YesOvertime.Foreground = new SolidColorBrush(Colors.Red);
                NoOvertime.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                YesOrNoOvertime = 0;
                GridTableOfHours.Visibility = Visibility.Collapsed;
                YesOvertime.Foreground = new SolidColorBrush(Colors.White);
            }
        }

        private void NoOvertime_Click(object sender, RoutedEventArgs e)
        {
            if (NoOvertime.IsChecked == true)
            {
                YesOrNoOvertime = 2;
                YesOvertime.IsChecked = false;
                GridTableOfHours.Visibility = Visibility.Collapsed;
                NoOvertime.Foreground = new SolidColorBrush(Colors.Red);
                YesOvertime.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                YesOrNoOvertime = 0;
                NoOvertime.Foreground = new SolidColorBrush(Colors.White);
            }

        }

        private void HelpSalaryInKind_Click(object sender, RoutedEventArgs e)
        {

            
            MessageBox.Show( " El salario en especie hace referencia a un pago que no sea monetario, por ejemplo alimentación, ropa, entre otros");
                
        }

        private void Finalized_Click(object sender, RoutedEventArgs e)
        {
            if (SalaryMonthly.IsChecked == true || SalaryFortnightly.IsChecked == true)
                YesOrNoFinalized = 1;
            if (ValueSalary.Text != "")
                YesOrNoFinalized += 1;
            if (HoursWorkedInWeek.Text != "")
                YesOrNoFinalized += 1;
            if (NoSalaryInKind.IsChecked == true)
                YesOrNoFinalized += 1;
            if (YesSalaryInKind.IsChecked == true)
                if (NoSalaryInKindAgreed.IsChecked == true)
                    YesOrNoFinalized += 1;
            if (YesSalaryInKind.IsChecked == true)
                if (YesSalaryInKindAgreed.IsChecked == true && HowManyIsSalaryInKind.Text != "")
                    YesOrNoFinalized += 1;
            if (NoOvertime.IsChecked == true)
                YesOrNoFinalized += 1;
            if (YesOvertime.IsChecked == true && (OvertimeSundayInDay.Text != "" || OvertimeWeekInDay.Text != "" || OvertimeWeekAtNight.Text != "" || OvertimeSundayAtNight.Text != ""))
                YesOrNoFinalized += 1;
            if (YesOrNoFinalized == 5)
            {
                NavigationService.Navigate(new Uri("/FinalizedPayroll.xaml", UriKind.Relative));
                YesOrNoFinalized = 0;
            }
            else
            {
                MessageBox.Show("Hay algún campo sin rellenar o la fecha es invalida por una incoherencia en el teimpo.");
                YesOrNoFinalized = 0;
            }
        }


        private void ValueSalary_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.PlatformKeyCode == 190 || ValueSalary.Text.Length == 25)
            {
                e.Handled = true;
            }
        }

        private void ValueSalary_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(ValueSalary.Text.Length > 3)
            ValueSalary.Text = ValueWithPoints(ValueSalary.Text);
            ValueSalary.Select(ValueSalary.Text.Length, 0);
            if (ValueSalary.Text != "")
            ValueSalaryActual = Convert.ToInt64(ValueWithinPoints(ValueSalary.Text));
        }



        private void HowManyIsSalaryInKind_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.PlatformKeyCode == 190 || HowManyIsSalaryInKind.Text.Length == 25)
            {
                e.Handled = true;
            }

        }

        private void HowManyIsSalaryInKind_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (HowManyIsSalaryInKind.Text.Length > 3)
                HowManyIsSalaryInKind.Text = ValueWithPoints(HowManyIsSalaryInKind.Text);
            HowManyIsSalaryInKind.Select(HowManyIsSalaryInKind.Text.Length, 0);
            if (HowManyIsSalaryInKind.Text != "")
                ValueHowManyIsSalaryInKind = Convert.ToInt64(ValueWithinPoints(HowManyIsSalaryInKind.Text));
        }

        private void HoursWorkedInWeek_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {

            if (e.PlatformKeyCode == 190)
            {
                e.Handled = true;
            }
        }

        private void OvertimeSundayInDay_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.PlatformKeyCode == 190)
            {
                e.Handled = true;
            }
        }

        private void OvertimeSundayAtNight_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.PlatformKeyCode == 190)
            {
                e.Handled = true;
            }
        }

        private void OvertimeWeekInDay_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.PlatformKeyCode == 190)
            {
                e.Handled = true;
            }
        }

        private void OvertimeWeekAtNight_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.PlatformKeyCode == 190)
            {
                e.Handled = true;
            }
        }

        private void HoursWorkedInWeek_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(HoursWorkedInWeek.Text != "")
            ValueHoursWorkedInWeek = int.Parse(HoursWorkedInWeek.Text);
        }

        private void OvertimeSundayInDay_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OvertimeSundayInDay.Text != "")
                ValueOvertimeSundayInDay = int.Parse(OvertimeSundayInDay.Text);
        }

        private void OvertimeWeekInDay_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OvertimeWeekInDay.Text != "")
                ValueOvertimeWeekInDay = int.Parse(OvertimeWeekInDay.Text);
        }

        private void OvertimeWeekAtNight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OvertimeWeekAtNight.Text != "")
                ValueOvertimeWeekAtNight = int.Parse(OvertimeWeekAtNight.Text);
        }

        private void OvertimeSundayAtNight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OvertimeSundayAtNight.Text != "")
                ValueOvertimeSundayAtNight = int.Parse(OvertimeSundayAtNight.Text);
        }

    }
 }
