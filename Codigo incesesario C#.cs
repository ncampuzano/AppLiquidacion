	private void Salary_TextChanged(object sender, TextChangedEventArgs e)
        {
            float SMMLV = 585006;
            ActualSalary = Convert.ToInt64(Salary.Text);
            if (Salary.Text != "")
            {
                if (float.Parse(Salary.Text) < SMMLV)
                {
                    GridTransportSubsidy.Visibility = Visibility.Visible;
                }
                else
                {
                    GridTransportSubsidy.Visibility = Visibility.Collapsed;

                }

            }
            else
                GridTransportSubsidy.Visibility = Visibility.Collapsed;



        }
		  private void TransportSubsidy_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValueTransportationSubsidary = Convert.ToInt64(TransportSubsidy.Text);
        }
 private void YesFiredJust_Click(object sender, RoutedEventArgs e)
        {
            if (YesFiredJust.IsChecked == true)
            {
                NoFiredJust.IsChecked = false;
                YesOrNoFiredJust = 1;
            }
            else
                YesOrNoFiredJust = 0;
        }
 private void NoFiredJust_Click(object sender, RoutedEventArgs e)
        {
            if (NoFiredJust.IsChecked == true)
            {
                YesFiredJust.IsChecked = false;
                YesOrNoFiredJust = 2;
            }
            else
                YesOrNoFiredJust = 0;
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
 public static string NumberIdentificationWorker;
        public static string NameWorker;
        // 1 TI 2 CC  CE 0 None
        public static int TypeOfIdentification = 0;
		
  DataOfWorker.Text = MainPage.NumberIdentificationWorker + "\n" + MainPage.NameWorker;