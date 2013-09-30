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
    public partial class FinalizedPayroll : PhoneApplicationPage
    {
        int SMLV = 585500;
        int ValueTransportSubsidy = 70500;
        long ValuePayroll;
        long ValueHourWorked;
        public long HowManyHourWorked(long ValueSalary, int HoursWorked, int FormPay)
        { 
            ValueSalary /= (HoursWorked / 7)* FormPay ;
            return ValueSalary;
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
        public FinalizedPayroll()
        {
            InitializeComponent();

            ValuePayroll = StartPayroll.ValueSalaryActual + StartPayroll.ValueHowManyIsSalaryInKind;
            
            Salary.Text =  "Sueldo: " + ValueWithPoints(StartPayroll.ValueSalaryActual.ToString());
            if (StartPayroll.ValueHowManyIsSalaryInKind != 0)
                SalaryInKind.Text = "Salario en especie: " + ValueWithPoints(StartPayroll.ValueHowManyIsSalaryInKind.ToString());
            if (StartPayroll.MonthlyOrFortnightly == 1)
            {
                if (StartPayroll.ValueSalaryActual < SMLV * 2)
                {
                    ValuePayroll += ValueTransportSubsidy;
                    TransportSubsidy.Text = "Subsidio de Transporte: " + ValueWithPoints(ValueTransportSubsidy.ToString()); 
                }   
               ValueHourWorked = HowManyHourWorked(StartPayroll.ValueSalaryActual, StartPayroll.ValueHoursWorkedInWeek, 30);
            }
            if (StartPayroll.MonthlyOrFortnightly == 2 )
            {
                if (StartPayroll.ValueSalaryActual < SMLV)
                {
                    ValuePayroll += ValueTransportSubsidy / 2;
                    TransportSubsidy.Text = "Subsidio de Transporte: " + ValueWithPoints((ValueTransportSubsidy/2).ToString()); 
                }
                ValueHourWorked = HowManyHourWorked(StartPayroll.ValueSalaryActual, StartPayroll.ValueHoursWorkedInWeek, 15);
            } 
            if(StartPayroll.ValueOvertimeSundayInDay != 0 || StartPayroll.ValueOvertimeWeekInDay  != 0 || StartPayroll.ValueOvertimeWeekAtNight != 0 || StartPayroll.ValueOvertimeSundayAtNight != 0)
            {
                ValuePayroll += StartPayroll.ValueOvertimeSundayInDay * ValueHourWorked * 2;
                ValuePayroll += Convert.ToInt64(StartPayroll.ValueOvertimeWeekInDay * ValueHourWorked * 1.25);
                ValuePayroll += Convert.ToInt64(StartPayroll.ValueOvertimeWeekAtNight * ValueHourWorked * 1.75);
                ValuePayroll += Convert.ToInt64(StartPayroll.ValueOvertimeSundayAtNight * ValueHourWorked * 2.25);
                Overtime.Text = ValueWithPoints(((Convert.ToInt32(StartPayroll.ValueOvertimeWeekInDay * ValueHourWorked * 1.25) + (StartPayroll.ValueOvertimeSundayInDay * ValueHourWorked * 2) + (StartPayroll.ValueOvertimeWeekAtNight * ValueHourWorked * 1.75) + (StartPayroll.ValueOvertimeSundayAtNight * ValueHourWorked * 2.25))).ToString());
            }
            long ValueSalaryTemp = ValuePayroll;
            Health.Text ="Salud: "  + ValueWithPoints((Convert.ToInt64(ValuePayroll* 0.04)).ToString());
            Pension.Text = "Pensiones: " + ValueWithPoints((Convert.ToInt64(ValuePayroll * 0.04)).ToString());
            ValuePayroll -= Convert.ToInt64((ValuePayroll * 0.08));

            if (StartPayroll.MonthlyOrFortnightly == 1 && StartPayroll.ValueSalaryActual > SMLV * 4)
            {
                Solidarity.Text = "Fondo de solidaridad: " + ValueWithPoints((Convert.ToInt64(ValuePayroll * 0.01)).ToString());
                ValuePayroll -= Convert.ToInt64(ValueSalaryTemp * 0.01);
            }
            if (StartPayroll.MonthlyOrFortnightly == 2 && StartPayroll.ValueSalaryActual < SMLV * 2)
            {
                Solidarity.Text = "Fondo de solidaridad: " + ValueWithPoints((Convert.ToInt64(ValuePayroll * 0.01)).ToString());
                ValuePayroll -= Convert.ToInt64(ValueSalaryTemp * 0.01);    
            }

            EndValuePayroll.Text =ValueWithPoints(ValuePayroll.ToString());
        }
    }
   
}