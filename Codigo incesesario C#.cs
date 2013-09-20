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
