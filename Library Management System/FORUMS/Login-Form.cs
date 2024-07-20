using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System.FORUMS
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox_User.Image = Image.FromFile("D:/lectures/BIT/SEM 2/project/LMS 2.0/Library Management System/Library Management System/IMAGES/user.png");
            pictureBox_Pass.Image = Image.FromFile("D:/lectures/BIT/SEM 2/project/LMS 2.0/Library Management System/Library Management System/IMAGES/key.png");
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.White;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //manipulate the dashboard form login form
        private Dashboard_Form dashf = null;
        public Login_Form(Dashboard_Form SourceForm)
        {
            
            dashf = SourceForm as Dashboard_Form;
            InitializeComponent();
        }

        //the login button
        private void button_login_Click(object sender, EventArgs e)
        {
            

            THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();


            string username = textBox_username.Text;
            string password = textBox_password.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `app_users` WHERE `username`=@usn AND `password`=@pass",db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            //check if this user exists or not
            if (table.Rows.Count > 0) //if exists
            {
                dashf.Enabled = true;
                this.Close();

            }
            else // if not
            {
                //check if the username empty
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username to Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //check if the password empty
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Password to Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //if this data doesn't exists
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }



        }


        
    }
}
