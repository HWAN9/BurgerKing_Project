﻿using System;
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
    public partial class Menu_Form1 : Form
    {
        public static readonly Home_Form1 homeForm1 = new Home_Form1();
        public static readonly Order_Form3 orderForm3 = new Order_Form3();
        public List<Menu> Burger = new List<Menu>();
        //세션
        static public string session;
        static public Locale store_obj;

        public Menu_Form1()
        {
            InitializeComponent();
            //var item23 = 1;
            //item23 = "aaaa";
            //var item2 = 2.0;
            //var ii = 'a';
            //var aaaa = "aaa";
            //var alkdjf = new Menu();
            //dynamic aa = new Menu();
            //aa = "aaaa";

            //foreach (var item in Controls)
            //{
            //    if(item is test.UserControl1)
            //    {
            //        (item as test.UserControl1).Click += select_menu;
            //    }
            //}
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowpan = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(flowLayoutPanel1, gunaVScrollBar1, true);

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Visible = false;
            homeForm1.Show();

        }

        private void userControl11_Load(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }
        public Menu mymenu;
        public List<Menu> selectMenu = new List<Menu>();
        private void select_menu(object sender, EventArgs e)
        {
            mymenu = new Menu();
            UserControl1 mySelect = (sender as UserControl1);
            mymenu.rownum = int.Parse(mySelect.Name.Split('_')[2]);

            //mymenu = mySelect.Name.Split('_')[2];
            //rownums.Add(rownum);
            Form1 form1 = new Form1(mymenu);

            if(mymenu.rownum<=12)
                form1.ShowDialog();
            else
            {
                mymenu.name = DataManager.menulist[mymenu.rownum-1].name;
                mymenu.price = DataManager.menulist[mymenu.rownum - 1].price;
                mymenu.category = DataManager.menulist[mymenu.rownum - 1].category;
            }

            DataManager.myList.Add(mymenu);

            guna2DataGridView1.DataSource = null;
            if (DataManager.myList.Count > 0)
                guna2DataGridView1.DataSource = DataManager.myList;


            //단품 or 세트
            //세트라면 그냥 세트인지 뭔가 바뀐건지

            //string name = 


            //Menu select = new Menu(  )

            //            selectMenu.Add();

            //          guna2DataGridView1.DataSource = null;
            //guna2DataGridView1.DataSource = MenuList;
            //MessageBox.Show("Test");

        }


        private void userControl_burger_1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            homeForm1.Show();
        }

        private void gunaButton2_MouseClick(object sender, MouseEventArgs e)
        {
            userControl_burger_2.Visible = false;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.gunaButton1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#d72300");
            this.gunaButton5.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");

            flowLayoutPanel2.Visible = false;
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel4.Visible = false;
            userControl_burger_1.Visible = false;
            userControl_burger_2.Visible = false;
            userControl_burger_3.Visible = false;
            userControl_burger_4.Visible = false;
            userControl_burger_5.Visible = true;
            userControl_burger_6.Visible = false;
            userControl_burger_7.Visible = true;
            userControl_burger_8.Visible = false;
            userControl_burger_9.Visible = true;
            userControl_burger_10.Visible = false;
            userControl_burger_11.Visible = true;
            userControl_burger_12.Visible = false;

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            this.gunaButton1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#d72300");
            this.gunaButton2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton5.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");

            flowLayoutPanel2.Visible = false;
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel1.Visible = true;
            flowLayoutPanel4.Visible = false;
            userControl_burger_1.Visible = true;
            userControl_burger_2.Visible = true;
            userControl_burger_3.Visible = true;
            userControl_burger_4.Visible = true;
            userControl_burger_5.Visible = true;
            userControl_burger_6.Visible = true;
            userControl_burger_7.Visible = true;
            userControl_burger_8.Visible = true;
            userControl_burger_9.Visible = true;
            userControl_burger_10.Visible = true;
            userControl_burger_11.Visible = true;
            userControl_burger_12.Visible = true;
        }

        private void gunaButton3_Click_1(object sender, EventArgs e)
        {
            Hide();
            orderForm3.SetText(session);
            orderForm3.setObj(this);
            orderForm3.ShowDialog();
            //Visible = true;

            //Close();
        }

        public void OrderClose()
        {
            guna2DataGridView1.DataSource = null;
            Close();
        }
        public void OrderContinue()
        {
            Show();
            guna2DataGridView1.DataSource = null;
            guna2DataGridView1.DataSource = DataManager.myList;
        }


        public void setObj(Locale myselect)
        {
             store_obj = myselect;

            //gunaLabel20.Text = store_obj.Name;
            //gunaLabel19.Text = store_obj.Phone;
            //gunaLabel18.Text = store_obj.Address;
        }

        public void SetText(string text)
        {
            session = text;
            //MessageBox.Show("메뉴" + session);
        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.gunaButton1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton5.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#d72300");
            this.gunaButton6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");

            flowLayoutPanel2.Visible = false;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel4.Visible = true;
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            this.gunaButton1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton5.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#d72300");

            flowLayoutPanel4.Visible = false;
            flowLayoutPanel2.Visible = true;
            flowLayoutPanel1.Visible = false;
            flowLayoutPanel3.Visible = false;
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            this.gunaButton1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton2.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton5.ForeColor = System.Drawing.ColorTranslator.FromHtml("#d72300");
            this.gunaButton4.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");
            this.gunaButton6.ForeColor = System.Drawing.ColorTranslator.FromHtml("#571c0c");

            flowLayoutPanel4.Visible = false;
            flowLayoutPanel1.Visible=false;
            flowLayoutPanel2.Visible=false;
            flowLayoutPanel3.Visible = true;
        }
    }
}
