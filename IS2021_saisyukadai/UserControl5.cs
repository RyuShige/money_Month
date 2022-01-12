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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void Next3_Click(object sender, EventArgs e)
        {
            Form1.ctr5.Visible = false;
            Form1.ctr6.Visible = true;

            double savingMonthly = (double.Parse(Form1.ctr3.AimSavings.Text) - double.Parse(Form1.ctr3.Savings.Text)) / double.Parse(Form1.ctr4.AimMonth.Text);

            double persent = savingMonthly / double.Parse(Form1.ctr3.Income.Text);

            double monthMoney = double.Parse(Form1.ctr3.Income.Text) - (double.Parse(Form1.ctr3.Income.Text) * persent + double.Parse(Form1.ctr5.FixedCost.Text));

            double roundedMonthMoney = Math.Round(monthMoney);

            Form1.ctr6.MonthMoney.Text = roundedMonthMoney.ToString();
        }

        private void Back3_Click(object sender, EventArgs e)
        {
            Form1.ctr5.Visible = false;
            Form1.ctr4.Visible = true;
        }
    }
}
