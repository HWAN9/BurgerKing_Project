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
            if(DataManager.myList.Count>0)
            {

                for(int i = 0; i<DataManager.myList.Count; i++)
                {
                    Menu item = DataManager.myList[i];
                    Label l1 = new Label();
                    Label l2 = new Label();
                    Label l3 = new Label();
                    l1.AutoSize = true;
                    l2.AutoSize = true;
                    l3.AutoSize = true;
                    l1.Text = $"{item.category}";
                    l2.Text = $"{item.name}";
                    l3.Text = $"{item.price}";

                    l1.Font = new System.Drawing.Font("타이포_다방구 B", 12F);
                    l2.Font = new System.Drawing.Font("타이포_다방구 B", 12F);
                    l3.Font = new System.Drawing.Font("타이포_다방구 B", 12F);
                    l1.Location = new Point(40, 90+((i+1)*70));
                    l2.Location = new Point(135, 90+((i+1)*70));
                    l3.Location = new Point(570, 90+((i+1)*70));
                    gunaLinePanel1.Controls.Add(l1);
                    gunaLinePanel1.Controls.Add(l2);
                    gunaLinePanel1.Controls.Add(l3);
                }
            }
        }
        public void setText(string s)
        {
            session = s;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            DataManager.myList.Clear();
            Close();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
