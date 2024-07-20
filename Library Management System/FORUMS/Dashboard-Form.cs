using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.FORUMS
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            pictureBox_Logo.Image = Image.FromFile("../../IMAGES/books.png");
            button_close.Image = Image.FromFile("../../IMAGES/crossx.png");
            button_books.Image = Image.FromFile("../../IMAGES/book.png");
            button_authors.Image = Image.FromFile("../../IMAGES/author.png");
            button_members.Image = Image.FromFile("../../IMAGES/user2.png");
            button_genres.Image = Image.FromFile("../../IMAGES/tag.png");
            button_circulation.Image = Image.FromFile("../../IMAGES/loop.png");
            button_users.Image = Image.FromFile("../../IMAGES/users.png");

            //display the last 4 books images.
            //we need to get last 5 rows from the book datatable.
            DataTable bookData = book.BooksList();

            //we need to create a loop to display the images
            byte[] img;
            MemoryStream ms;
            int i = 0; //index for the table rows

            //foreach loop to clear all textboxes
            foreach (var panelControl in panel_displayBooks_.Controls)
            {
                if (panelControl.GetType() == typeof(Panel))
                {
                    //display the book image
                    Panel panel = (Panel)panelControl;
                    img = (byte[])bookData.Rows[i][10];
                    ms = new MemoryStream(img);
                    panel.BackgroundImage = Image.FromStream(ms);
                    panel.BackgroundImageLayout = ImageLayout.Stretch;

                    //display the book price
                    foreach (var labelControl in panel.Controls)
                    {
                        if (labelControl.GetType() == typeof(Label))
                        {
                            Label label = (Label)labelControl;
                            label.Text = "Rs." + bookData.Rows[i][6].ToString();
                        }
                    }

                    i++;
                }
            }

           
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        CLASSES.MEMBER member = new CLASSES.MEMBER();


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Logo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button_users_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
        
            this.Enabled = false;

            //show the login form
            Login_Form lgf = new Login_Form(this);
            lgf.Show();

            //show the numer of authors /books / members 
            label_booksCount.Text = book.BooksList().Rows.Count.ToString();
            label_authorsCount.Text = author.AuthorsList(false).Rows.Count.ToString();
            label_membersCount.Text = member.MembersList(false).Rows.Count.ToString();

        }  

        private void button_genres_Click(object sender, EventArgs e)
        {
            //show the manage genres form
            MangeGenresForm mngGnrF = new MangeGenresForm();
            mngGnrF.Show();

        }

        private void button_authors_Click(object sender, EventArgs e)
        {
            //show the manage Authors form
            ManageAuthorsForm mngAthF = new ManageAuthorsForm();
            mngAthF.Show();
        }

        private void button_books_Click(object sender, EventArgs e)
        {
            //show the manage Books Form
            ManageBooksForm mngBksF = new ManageBooksForm();
            mngBksF.Show();
        }

        private void button_Members_Click(object sender, EventArgs e)
        {
            //show the manage members Form
            ManageMembersForm mngMbrF = new ManageMembersForm();
            mngMbrF.Show();
        }

        private void label_price3_Click(object sender, EventArgs e)
        {

        }

        private void label_price4_Click(object sender, EventArgs e)
        {

        }
    }
}
