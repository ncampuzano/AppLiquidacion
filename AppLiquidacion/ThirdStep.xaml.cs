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
    public partial class ThirdStep : PhoneApplicationPage
    {
        public static double SalaryTemp = 0;
        public static double AverageSalary = 0;
        public double KnowSalaryWhenItChanged()
        {
            DateTime ActualYear = new DateTime(StepOne.DayEndWork.Year, 1, 1);
            double AmountMonthsWorkedInActualYear = (StepOne.DayEndWork - ActualYear).TotalDays / 30;
            if (AmountMonthsWorkedInActualYear <= 12)
            { 
                for (int a = 0; a < StepOne.MonthsChangedSalary ; a++)
                {
                    SalaryTemp += StepOne.ActualSalary;
                }
                for (int a = 0; a < (12 - StepOne.MonthsChangedSalary) ; a++)
                {
                    SalaryTemp += StepOne.ValueOldSalary;
                }
            }
            /*
                {
                for (int a = 0; a < StepOne.MonthsChangedSalary ; a++)
                {
                    SalaryTemp += StepOne.ActualSalary;
                }
                for (int a = 0; a < (AmountMonthsWorked - StepOne.MonthsChangedSalary) ; a++)
                {
                    SalaryTemp += StepOne.ValueOldSalary;
                }*/
           
        return SalaryTemp;
                   
        }
        public ThirdStep()
        {
            double ValueLiquidate = 0;
            int TwoSMMLV = 1170000;
            InitializeComponent();
            if (StepOne.ActualSalary < TwoSMMLV && StepOne.YesOrNoSalaryInKindAgreed == 1 && StepOne.YesOrNoSalaryChanged == 1)
            {
                AverageSalary = (KnowSalaryWhenItChanged() + StepOne.ValuePayInKind * 12 + StepOne.ValueTransportationSubsidary * 12) / 12;
            }
            else
            {
                if (StepOne.ActualSalary < TwoSMMLV && StepOne.YesOrNoSalaryInKindAgreed == 1)
                {
                    AverageSalary = (StepOne.ActualSalary * 12 + StepOne.ValuePayInKind * 12) / 12;
                }
                else 
                {
                    if (StepOne.ActualSalary < TwoSMMLV && StepOne.YesOrNoSalaryChanged == 1)
                    {
                        AverageSalary = (StepOne.ValueTransportationSubsidary * 12 + KnowSalaryWhenItChanged()) / 12;
                    }
                    else
                    {
                        if (StepOne.YesOrNoSalaryInKindAgreed == 1 && StepOne.YesOrNoSalaryChanged == 1)
                        {
                            AverageSalary = (StepOne.ValuePayInKind * 12 + KnowSalaryWhenItChanged()) / 12;
                        }
                        else
                        {
                            if (StepOne.ActualSalary < TwoSMMLV)
                            {
                                AverageSalary = (StepOne.ActualSalary * 12 + StepOne.ValueTransportationSubsidary * 12) / 12;
                            }
                            else
                            {
                                if (StepOne.YesOrNoSalaryInKindAgreed == 1)
                                {
                                    AverageSalary = (StepOne.ActualSalary * 12 + StepOne.ValuePayInKind * 12) / 12;
                                }
                                else
                                {
                                    if (StepOne.YesOrNoSalaryChanged == 1)
                                    {
                                        AverageSalary = KnowSalaryWhenItChanged() / 12;
                                    }
                                    else
                                    {
                                        if (StepOne.ActualSalary > TwoSMMLV && (StepOne.YesOrNoSalaryInKindAgreed == 2 || StepOne.YesOrNoSalaryInKindAgreed == 0) && StepOne.YesOrNoSalaryChanged == 2)
                                        {
                                            AverageSalary = StepOne.ActualSalary;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            ValueLiquidate = AverageSalary;
            if (StepTwo.YesOrNoOwesVacations == 1)
                {
                    ValueLiquidate += (StepTwo.NumberDaysOwesVacations * (StepOne.ActualSalary / 2) * 12) / 360;
                }
            if (StepTwo.YesOrNoPaySevenceAtTheTime == 2)
            {
                ValueLiquidate += ((StepOne.DayEndWork - StepTwo.DayNoPaySeverence).TotalDays * AverageSalary) / 360;
                int ValueSevecence = Convert.ToInt32(((StepOne.DayEndWork - StepTwo.DayNoPaySeverence).TotalDays * AverageSalary) / 360); 
                ValueLiquidate += (ValueSevecence * (StepOne.DayEndWork - StepTwo.DayNoPaySeverence).TotalDays * 0.12)/360;
            }
            else {

                if (StepOne.DayEndWork.Year != StepOne.DayStartWork.Year)
                {
                    DateTime ActualYear = new DateTime(StepOne.DayEndWork.Year, 1, 1);
                    ValueLiquidate += ((StepOne.DayEndWork - ActualYear).TotalDays * AverageSalary) / 360;
                    int ValueSevecence = Convert.ToInt32(((StepOne.DayEndWork - ActualYear).TotalDays * AverageSalary) / 360);
                    ValueLiquidate += (ValueSevecence * (StepOne.DayEndWork - ActualYear).TotalDays * 0.12) / 360;
                }
                else
                {
                    ValueLiquidate += ((StepOne.DayEndWork - StepOne.DayStartWork).TotalDays * AverageSalary) / 360;
                    int ValueSevecence = Convert.ToInt32(((StepOne.DayEndWork - StepOne.DayStartWork).TotalDays * AverageSalary) / 360);
                    ValueLiquidate += (ValueSevecence * (StepOne.DayEndWork - StepOne.DayStartWork).TotalDays * 0.12) / 360;
                }
            }

           ValueLiquidateNumber.Text = Convert.ToInt32(ValueLiquidate).ToString();

        }
      }
 }
    
