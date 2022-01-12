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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();

            
        }

        private void Back4_Click(object sender, EventArgs e)
        {
            Form1.ctr6.Visible = false;
            Form1.ctr5.Visible = true;
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1.ctr6.Visible = false;
            Form1.ctr3.Visible = true;
        }
    }
}
