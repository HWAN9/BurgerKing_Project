using MySql.Data.MySqlClient;
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
    public partial class Order_Form3 : Form
    {
        public Menu_Form1 menuForm1 = new Menu_Form1();
        public static Search_Form1 searchForm1 = new Search_Form1();
        public static Home_Form1 homeForm1 = new Home_Form1();
        //세션 아이디
        static public string session;
        
        public Order_Form3()
        {
            InitializeComponent();

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            menuForm1.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            menuForm1.Show();
        }

        private void gunaLinePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void setObj(Menu_Form1 m)
        {
            Locale store_obj = DataManager.myselect;
            menuForm1 = m;

            if(DataManager.myList.Count > 1)
            {
                gunaLabel26.Text = DataManager.myList[0].name + "외";
            }
            else
            {
                gunaLabel26.Text = DataManager.myList[0].name;
            }
            int sum = 0;
                foreach (Menu item in DataManager.myList)
                {
                    sum += int.Parse(item.price);
                }
                gunaLabel28.Text = sum.ToString();


            gunaLabel20.Text = store_obj.Name;
            gunaLabel19.Text = store_obj.Phone;
            gunaLabel18.Text = store_obj.Address;
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            Close();
            menuForm1.OrderContinue();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            homeForm1.Show();
        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }
        public void SetText(string data)
        {
            session = data;
            callInfo();
        }

        private void callInfo()
        {
            string id = session;
            string dbname = "";
            string dbphone_num = "";
            string dbaddress = "";
            var connectionString = "server=localhost;port=2421;user=root;database=burgerking;password=1234";
            var connection = new MySqlConnection(connectionString);
            string insertQuery = $"SELECT * FROM member where id='{id}'";

            
            try
            {
                connection.Open();
                //label3.Text = "Connected";

                var command = new MySqlCommand(insertQuery, connection);
                command.ExecuteNonQuery();

                MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dbname = reader["name"].ToString();
                        dbphone_num = reader["phone_num"].ToString();
                        dbaddress = reader["address"].ToString();
                    }
                    gunaLabel8.Text = dbname;
                    gunaLabel9.Text = dbphone_num;
                    gunaLabel10.Text = dbaddress;

                }
                else
                {

                    gunaLabel8.Text = "비회원";
                    gunaLabel9.Text = "-";
                    gunaLabel10.Text = "매장수령";
                    //MessageBox.Show("잘못된 ID 입니다.");
                }


            }
            catch (Exception ex)
            {
                //label3.Text = "Disconnected";
            }
            connection.Close();
        }

        private void insertOrder(string menu, string user_name, string hp, string sql_id)
        {
            var connectionString = "server=localhost;port=2421;user=root;database=burgerking;password=1234";
            var connection = new MySqlConnection(connectionString);
            string insertQuery = $"INSERT INTO ORDER_MENU(MENU, USER_NAME, HP, ID) VALUES ({menu}, {user_name}, {hp}, {sql_id})";

            try
            {
                connection.Open();
                //label3.Text = "Connected";

                var command = new MySqlCommand(insertQuery, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //label3.Text = "Disconnected";
            }
            connection.Close();
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            Hide();
            menuForm1.OrderClose();
            Order_Form2 orderForm2 = new Order_Form2();
            orderForm2.setText(session);
            orderForm2.ShowDialog();

            string fullName = "";

            foreach (var item in DataManager.myList)
            {
                fullName += item.name + ", ";
            }
            insertOrder(fullName, gunaLabel8.Text, gunaLabel9.Text, session);
            Close();
        }

        private void gunaLabel13_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel17_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel20_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaLabel26_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel25_Click(object sender, EventArgs e)
        {

        }
    }
}
