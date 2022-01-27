using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Order_Form2 : Form
    {
        public static readonly Home_Form1 homeForm1 = new Home_Form1();
        public string session;
        public Order_Form2()
        {
            InitializeComponent();
        }
        public void setText(string s)
        {
            session = s;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Hide();
            homeForm1.SetText(session);
            homeForm1.ShowDialog();
            Close();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            homeForm1.SetText(session);
            homeForm1.ShowDialog();
            Close();
        }
    }
}
