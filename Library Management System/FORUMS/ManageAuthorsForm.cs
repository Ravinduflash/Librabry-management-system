using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.FORUMS
{
    public partial class ManageAuthorsForm : Form
    {
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();


        public ManageAuthorsForm()
        {
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageAuthorsForm_Load(object sender, EventArgs e)
        {
            //display header image
            pictureBox_authors.Image = Image.FromFile("../../IMAGES/typewriter.png");

            //display button images
            button_add.Image = Image.FromFile("../../IMAGES/plus.png");
            button_edit.Image = Image.FromFile("../../IMAGES/update.png");
            button_delete.Image = Image.FromFile("../../IMAGES/trash.png");

            //populate datagridview with Author
            dataGridView_authors.DataSource = author.AuthorsList(false);

            //customize datagridview header
            dataGridView_authors.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_authors.EnableHeadersVisualStyles = false;

            //show the numer of authors
            label_authorsCount.Text = author.AuthorsList(false).Rows.Count.ToString() + " Authors";


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
                  
        }


        // button edit author
        private void button1_Click(object sender, EventArgs e)
        {

        }


        // add a new author
        private void button_add_Click(object sender, EventArgs e)
        {

            string first_name = textBox_fname.Text;
            string last_name = textBox_lname.Text;
            string education = textBox_education.Text;
            string bio = richTextBox_bio.Text;

            // check if the first/last name are empty.
            if (first_name.Trim().Equals("") || last_name.Trim().Equals(""))
            {
                MessageBox.Show("You Need To Enter The Author First & Last Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (author.addAuthor(first_name, last_name, education, bio))
                {
                    MessageBox.Show("New Author Added Successfully", "New Author", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refresh datagridview
                    dataGridView_authors.DataSource = author.AuthorsList(false);

                    //update the numer of authors
                    label_authorsCount.Text = author.AuthorsList(false).Rows.Count.ToString() + " Authors";

                }
                else
                {
                    MessageBox.Show("Author Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void label_name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        //button edit author
        private void button_edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string first_name = textBox_fname.Text;
                string last_name = textBox_lname.Text;
                string education = textBox_education.Text;
                string bio = richTextBox_bio.Text;

                // check if the first/last name are empty.
                if (first_name.Trim().Equals("") || last_name.Trim().Equals(""))
                {
                    MessageBox.Show("You Need To Enter The Author First & Last Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (author.editAuthor(id, first_name, last_name, education, bio))
                    {
                        MessageBox.Show("The Author Data Has Been Updated Successfully", "Edit Author", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //refresh datagridview
                        dataGridView_authors.DataSource = author.AuthorsList(false);

                    }
                    else
                    {
                        MessageBox.Show("Author Data Not Updated", "Edit-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Invalid Author ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_authors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_authors.CurrentRow.Cells[0].Value.ToString();
            textBox_fname.Text = dataGridView_authors.CurrentRow.Cells[1].Value.ToString();
            textBox_lname.Text = dataGridView_authors.CurrentRow.Cells[2].Value.ToString();
            textBox_education.Text = dataGridView_authors.CurrentRow.Cells[3].Value.ToString();
            richTextBox_bio.Text = dataGridView_authors.CurrentRow.Cells[4].Value.ToString();

        }

        //button delete author
        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);

                // show a confirmation message before deleting the author
                if (MessageBox.Show("Do You Want to Delete This Author?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (author.removeAuthor(id))
                    {

                        MessageBox.Show("The Author Data Has Been Deleted Successfully", "Remove Author", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clear fields
                        textBox_id.Text = "";
                        textBox_fname.Text = "";
                        textBox_lname.Text = "";
                        textBox_education.Text = "";
                        richTextBox_bio.Text = "";


                        //refresh datagridview
                        dataGridView_authors.DataSource = author.AuthorsList(false);

                        //edit  the numer of authors
                        label_authorsCount.Text = author.AuthorsList(false).Rows.Count.ToString() + " Authors";

                    
                    }
                    else
                    {
                        MessageBox.Show("The Author Has Not Been Deleted", "Remove Author", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
     
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Invalid Author ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
           


        }


        //show the selected author books
        private void button_Show_Author_Books_Click(object sender, EventArgs e)
        {
            int authorId = Convert.ToInt32(dataGridView_authors.CurrentRow.Cells[0].Value.ToString());
            string fname = dataGridView_authors.CurrentRow.Cells[1].Value.ToString();
            string lname = dataGridView_authors.CurrentRow.Cells[2].Value.ToString();
            string fullName = fname + " " + lname;
            BookListForm bkLsFrm = new BookListForm(authorId, fullName);
            bkLsFrm.Show();
        }

        private void label_authorsCount_Click(object sender, EventArgs e)
        {

        }

        private void button_ClearFields_Click(object sender, EventArgs e)
        {
            textBox_id.Text = "";
            textBox_fname.Text = "";
            textBox_lname.Text = "";
            textBox_education.Text = "";
            richTextBox_bio.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_authors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}