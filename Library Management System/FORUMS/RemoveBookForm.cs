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
    public partial class RemoveBookForm : Form
    {
        public RemoveBookForm()
        {
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown_BookId_ValueChanged(object sender, EventArgs e)
        {

        }

        //button remove book
        CLASSES.BOOKS books = new CLASSES.BOOKS();
        private void button_RemoveBook_Click(object sender, EventArgs e)
        {
            int bookId = (int)numericUpDown_BookId.Value;

           // show a confirmation message before deleting the book
            if (MessageBox.Show("Do You Want to Delete This Book?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (books.removeBook(bookId))
                {
                    MessageBox.Show("The Book Data Has Been Deleted Successfully", "Remove Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("The Book Has Not Been Deleted", "Remove Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
          
        }
    }
}
