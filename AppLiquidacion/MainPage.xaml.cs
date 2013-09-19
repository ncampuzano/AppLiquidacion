using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace AppLiquidacion
{
    public partial class MainPage : PhoneApplicationPage
    {
        public static string NumberIdentificationWorker;
        public static string NameWorker;
        // 1 TI 2 CC  CE 0 None
        public static int TypeOfIdentification = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Comenzar_Click(object sender, RoutedEventArgs e)
        {
            NumberIdentificationWorker = IdentificationWorker.Text;
            NameWorker = BoxNameWorker.Text;
            if(IdentificationWorker.Text != "" && BoxNameWorker.Text != "" && TypeOfIdentification != 0)
            {
                NavigationService.Navigate(new Uri("/StepOne.xaml", UriKind.Relative));
            }
        }


        private void IdentificationWorker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.PlatformKeyCode == 190)
            {
                e.Handled = true;
            }
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            if (CE.IsChecked == true)
            {
                CC.IsChecked = false;
                TI.IsChecked = false;
                TypeOfIdentification = 3;
            }
            else
                TypeOfIdentification = 0;
        }

        private void CC_Click(object sender, RoutedEventArgs e)
        {
            if (CC.IsChecked == true)
            {
                CE.IsChecked = false;
                TI.IsChecked = false;
                TypeOfIdentification = 2;
            }
            else
                TypeOfIdentification = 0;

        }

        private void TI_Click(object sender, RoutedEventArgs e)
        {

            if (TI.IsChecked == true)
            {
                CE.IsChecked = false;
                CC.IsChecked = false;
                TypeOfIdentification = 1;
            }
            else
                TypeOfIdentification = 0;
        }

    }
}