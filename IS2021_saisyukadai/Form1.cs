using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS2021_saisyukadai
{
    public partial class Form1 : Form
    {

        //staticで宣言することでインスタンスを固定
        public static UserControl1 ctr1;
        public static UserControl2 ctr2;
        public static UserControl3 ctr3;
        public static UserControl4 ctr4;
        public static UserControl5 ctr5;
        public static UserControl6 ctr6;
        //public static UserControl7 ctr7;
        public Form1()
        {
            InitializeComponent();

            ctr1 = new UserControl1();
            ctr2 = new UserControl2();
            ctr3 = new UserControl3();
            ctr4 = new UserControl4();
            ctr5 = new UserControl5();
            ctr6 = new UserControl6();
            //ctr7 = new UserControl7();

            //パネルにコントロール１、２を追加
            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);
            panel1.Controls.Add(ctr3);
            panel1.Controls.Add(ctr4);
            panel1.Controls.Add(ctr5);
            panel1.Controls.Add(ctr6);
            //panel1.Controls.Add(ctr7);

            //コントロール1のみを見えるようにする
            ctr1.Visible = true;
            ctr2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
