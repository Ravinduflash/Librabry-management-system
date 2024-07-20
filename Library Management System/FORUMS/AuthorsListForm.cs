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
    public partial class AuthorsListForm : Form 
    {
    
        private ManageBooksForm mngBooks = null;

        public AuthorsListForm(ManageBooksForm sourceForm)
        {

            mngBooks = sourceForm as ManageBooksForm;
            InitializeComponent();
        }


        

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        // display authors list on the listbox 
        private void AuthorsListForm_Load(object sender, EventArgs e)
        {
            CLASSES.AUTHOR author = new CLASSES.AUTHOR();
            listBox_authors.DataSource = author.AuthorsList(true);
            listBox_authors.DisplayMember = "fullName";
            listBox_authors.ValueMember = "id";


        }

        //button to set the selected author id into the manage book form
        //and close this form
        private void button_selectAndClose_Click(object sender, EventArgs e)
        {
            try
            {
                //get the author fullname and id

                DataRowView drv = (DataRowView)listBox_authors.SelectedItem;
                string fullname = drv["fullname"].ToString();
                string id = drv["id"].ToString();

                // display the id and the fullname
                //the fullname will be displayed in the panel add and edit
                //for add
                mngBooks.textBox_authorFullname.Text = fullname;
                mngBooks.label_author_id.Text = id;

                //for edit
                mngBooks.textBox_Author_Edit.Text = fullname;
                mngBooks.label_AuthorId_Edit.Text = id;


            }
            catch (Exception ex)
            {
                MessageBox.Show("No Author Selected " + ex.Message);
            }

            //


            //close
            this.Close();
        }

        private void listBox_authors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
