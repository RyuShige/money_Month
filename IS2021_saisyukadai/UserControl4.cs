using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS2021_saisyukadai
{
    public partial class UserControl4 : UserControl
    {
       
        public UserControl4()
        {
            InitializeComponent();
        }

        private void Next2_Click(object sender, EventArgs e)
        {
            Form1.ctr4.Visible = false;
            Form1.ctr5.Visible = true;
        }

        private void Calc1_Click(object sender, EventArgs e)
        {
            double savingMonthly = (double.Parse(Form1.ctr3.AimSavings.Text) - double.Parse(Form1.ctr3.Savings.Text)) / double.Parse(Form1.ctr4.AimMonth.Text);

            double persent = savingMonthly / double.Parse(Form1.ctr3.Income.Text) * 100;

            double roundedPersent = Math.Round(persent, 1);

            Percent.Text = roundedPersent.ToString();
        }

        private void Back2_Click(object sender, EventArgs e)
        {
            Form1.ctr4.Visible = false;
            Form1.ctr3.Visible = true;
        }
    }
}
