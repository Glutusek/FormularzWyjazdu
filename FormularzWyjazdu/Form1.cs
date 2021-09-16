using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularzWyjazdu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActualDate.Value = DateTime.Now;
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ArriveDate_ValueChanged(object sender, EventArgs e)
        {
            if(LeaveDate.Value < ArriveDate.Value)
            {
                MessageBox.Show("Ustaw poprawną datę odjazdu!");
            } 
            else
            {
                NumOfDays.Text = (LeaveDate.Value.Date - ArriveDate.Value.Date).Days.ToString();
            }
        }

        private void LeaveDate_ValueChanged(object sender, EventArgs e)
        {
            if (LeaveDate.Value < ArriveDate.Value)
            {
                MessageBox.Show("Ustaw poprawną datę przyjazdu!");
            }
            else
            {
                NumOfDays.Text = ((LeaveDate.Value.Date - ArriveDate.Value.Date)).Days.ToString();
            }
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            double TotalPriceSum = (double)((LeaveDate.Value.Date - ArriveDate.Value.Date).Days * Price.Value);

            bool promotion = false;

            int ArriveDateDay = ArriveDate.Value.Day;
            int ArriveDateMonth = ArriveDate.Value.Month;
            int ArriveDateYear = ArriveDate.Value.Year;

            int BornDateDay = BornDate.Value.Day;
            int BornDateMonth = BornDate.Value.Month;

            int LeaveDateDay = LeaveDate.Value.Day;
            int LeaveDateMonth = LeaveDate.Value.Month;
            int LeaveDateYear = LeaveDate.Value.Year;

            if(ArriveDateYear != LeaveDateYear)
            {
                if(ArriveDate.Value.DayOfYear <= BornDate.Value.DayOfYear)
                {
                    
                }
                else
                {
                    promotion = true;
                }


            }

            
               /* TotalPriceSum *= 0.9;
                TotalPrice.Text = TotalPriceSum.ToString() + " zł\nPrzysługuje Ci zniżka 10% za pobyt w dniu urodzin z nami!";
            
                TotalPrice.Text = TotalPriceSum.ToString() + " zł";*/
        }
    }
}
