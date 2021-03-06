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
    public partial class ThirdStep : PhoneApplicationPage
    {
        public static double SalaryTemp = 0;
        public static double AverageSalary = 0;
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
            int SLMV = 580500;
            int TwoSMMLV = SLMV * 2 ;
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
            Salary.Text = "Sueldo promedio: " + ValueWithPoints(StepOne.ActualSalary.ToString());
            StackSalary.Visibility = Visibility.Visible;
            if (AverageSalary < (SLMV * 2))
            {
                SubsidyTransport.Text = "Subsidio de transporte: 70,5000";
                StackSubsidyTransport.Visibility = Visibility.Visible;
            }
            if (StepOne.YesOrNoSalaryInKindAgreed == 1)
            {
                SalaryInKind.Text = "Salario en especie: " + ValueWithPoints(StepOne.ValuePayInKind.ToString());
                StackSalaryInKind.Visibility = Visibility.Visible;
            }
            if (StepTwo.YesOrNoOwesVacations == 1)
                {
                    ValueLiquidate += (StepTwo.NumberDaysOwesVacations * (StepOne.ActualSalary / 2) * 12) / 360;
                   Vacations.Text = "Vacaciones: " + ValueWithPoints(((StepTwo.NumberDaysOwesVacations * (StepOne.ActualSalary / 2) * 12) / 360).ToString());
                   StackVacations.Visibility = Visibility.Visible;    
                }
            if (StepTwo.YesOrNoPaySevenceAtTheTime == 2)
            {
                ValueLiquidate += ((StepOne.DayEndWork - StepTwo.DayNoPaySeverence).TotalDays * AverageSalary) / 360;
                int ValueSevecence = Convert.ToInt32(((StepOne.DayEndWork - StepTwo.DayNoPaySeverence).TotalDays * AverageSalary) / 360); 
                ValueLiquidate += (ValueSevecence * (StepOne.DayEndWork - StepTwo.DayNoPaySeverence).TotalDays * 0.12)/360;
                Severence.Text = "Cesantiase e intereses de cesantias: " + ValueWithPoints(Convert.ToInt64(((ValueSevecence * (StepOne.DayEndWork - StepTwo.DayNoPaySeverence).TotalDays * 0.12) / 360) + (((StepOne.DayEndWork - StepTwo.DayNoPaySeverence).TotalDays * AverageSalary) / 360)).ToString());
                StackSeverence.Visibility = Visibility.Visible;
            }
            else {

                if (StepOne.DayEndWork.Year != StepOne.DayStartWork.Year)
                {
                    DateTime ActualYear = new DateTime(StepOne.DayEndWork.Year, 1, 1);
                    ValueLiquidate += ((StepOne.DayEndWork - ActualYear).TotalDays * AverageSalary) / 360;
                    int ValueSevecence = Convert.ToInt32(((StepOne.DayEndWork - ActualYear).TotalDays * AverageSalary) / 360);
                    ValueLiquidate += (ValueSevecence * (StepOne.DayEndWork - ActualYear).TotalDays * 0.12) / 360;
                    Severence.Text = "Cesantiase e intereses de cesantias: " + ValueWithPoints(Convert.ToInt64((((StepOne.DayEndWork - ActualYear).TotalDays * AverageSalary) / 360) + ((ValueSevecence * (StepOne.DayEndWork - ActualYear).TotalDays * 0.12) / 360)).ToString());
                    StackSeverence.Visibility = Visibility.Visible;
                }
                else
                {
                    ValueLiquidate += ((StepOne.DayEndWork - StepOne.DayStartWork).TotalDays * AverageSalary) / 360;
                    int ValueSevecence = Convert.ToInt32(((StepOne.DayEndWork - StepOne.DayStartWork).TotalDays * AverageSalary) / 360);
                    ValueLiquidate += (ValueSevecence * (StepOne.DayEndWork - StepOne.DayStartWork).TotalDays * 0.12) / 360;
                    Severence.Text = "Cesantiase e intereses de cesantias: " + ValueWithPoints(Convert.ToInt64((ValueLiquidate += ((StepOne.DayEndWork - StepOne.DayStartWork).TotalDays * AverageSalary) / 360) + (ValueLiquidate += (ValueSevecence * (StepOne.DayEndWork - StepOne.DayStartWork).TotalDays * 0.12) / 360)).ToString());
                    StackSeverence.Visibility = Visibility.Visible;
                }
            }
            if (StepOne.GoodFired == 2)
            {
                if (StepOne.DayEndWork.Year != StepOne.DayStartWork.Year)
                {   double Hola =(StepOne.DayEndWork - StepOne.DayStartWork).TotalDays;
                    double YearDayswWorked =  Hola / 360;
                    double ValueCompesation = 0;
                    if (StepOne.ActualSalary < (SLMV * 10))
                    {
                        if (YearDayswWorked >= 1)
                        {
                            ValueLiquidate += StepOne.ActualSalary * ((1 * 360 * 0.3) / 360);
                            ValueCompesation += StepOne.ActualSalary * ((1 * 360 * 0.3) / 360);
                            YearDayswWorked -= 1;
                            for (int a = 1; a < YearDayswWorked; )
                            {
                                ValueLiquidate += StepOne.ActualSalary * ((1 * 360 * 0.2) / 360);
                                ValueCompesation += StepOne.ActualSalary * ((1 * 360 * 0.2) / 360);
                                YearDayswWorked -= 1;
                            }
                            if (YearDayswWorked > 0)
                            {
                                ValueLiquidate += StepOne.ActualSalary * ((YearDayswWorked * 360 * 0.2) / 360);
                            }
                        }
                    }
                    else 
                    {
                        if (YearDayswWorked >= 1)
                        {
                            ValueLiquidate += StepOne.ActualSalary * ((1 * 360 * 0.2) / 360);
                            ValueCompesation += StepOne.ActualSalary * ((1 * 360 * 0.2) / 360);
                            YearDayswWorked -= 1;
                            for (int a = 1; a < YearDayswWorked; )
                            {
                                ValueLiquidate += StepOne.ActualSalary * ((1 * 360 * 0.15) / 360);
                                ValueCompesation += StepOne.ActualSalary * ((1 * 360 * 0.15) / 360);
                                YearDayswWorked -= 1;
                            }
                            if (YearDayswWorked > 0)
                            {
                                ValueLiquidate +=  StepOne.ActualSalary * ((YearDayswWorked * 360 * 0.15) / 360);
                            }
                        }
                       
                    }
                    Compensation.Text = "Indemnización: " + ValueWithPoints ((Convert.ToInt32(ValueCompesation)).ToString());
                    StackCompensation.Visibility = Visibility.Visible;
                }
                else
                {
                    if (StepOne.ActualSalary < (SLMV * 10))
                    {
                        ValueLiquidate += StepOne.ActualSalary * (((StepOne.DayEndWork - StepOne.DayStartWork).TotalDays * 0.3) / 360);
                        Compensation.Text = "Indemnización: " + ValueWithPoints((Convert.ToInt32(StepOne.ActualSalary * (((StepOne.DayEndWork - StepOne.DayStartWork).TotalDays * 0.3) / 360))).ToString());
                        StackCompensation.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        ValueLiquidate += StepOne.ActualSalary * (((StepOne.DayEndWork - StepOne.DayStartWork).TotalDays * 0.2) / 360);
                        Compensation.Text = "Indemnización: " + ValueWithPoints((Convert.ToInt32(StepOne.ActualSalary * (((StepOne.DayEndWork - StepOne.DayStartWork).TotalDays * 0.2) / 360))).ToString());
                        StackCompensation.Visibility = Visibility.Visible;
                    }
                }
            }
                ValueLiquidateNumber.Text = ValueWithPoints(Convert.ToInt32(ValueLiquidate).ToString());
        }  
    }
}
    
    
