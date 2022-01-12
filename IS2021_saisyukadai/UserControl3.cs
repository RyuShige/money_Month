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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void Next1_Click(object sender, EventArgs e)
        {
            Form1.ctr3.Visible = false;
            Form1.ctr4.Visible = true;
        }

        private void Back1_Click(object sender, EventArgs e)
        {
            Form1.ctr3.Visible = false;
            Form1.ctr2.Visible = true;
        }
    }
}
