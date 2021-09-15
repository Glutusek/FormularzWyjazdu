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
    }
}
