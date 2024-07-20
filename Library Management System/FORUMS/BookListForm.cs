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
    public partial class BookListForm : Form
    {
        int author_id;
        string fullname;

        public BookListForm(int id, string FullName)
        {
            InitializeComponent();
            this.author_id = id;
            this.fullname = FullName;
        }

       

        private void button_login_Click(object sender, EventArgs e)
        {

        }

        private void label_Close__Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            //display selected author fullname
            label_author.Text = "books by: " + fullname;

            //display the author books in the list view.
            CLASSES.BOOKS book = new CLASSES.BOOKS();
            DataTable booksList = book.authorBooks(author_id);

            ListViewItem[] items = new ListViewItem[booksList.Rows.Count];
            String[] titles = new String[booksList.Rows.Count];

            //loop to populate the titles & images
            for (int i = 0; i < booksList.Rows.Count; i++)
            {
                byte[] img = (byte[])booksList.Rows[i][10];
                MemoryStream ms = new MemoryStream(img);

                //add images to the image list
                imageList_BookCovers.Images.Add(Image.FromStream(ms));

                //add title to the titles array
                titles[i] = booksList.Rows[i][2].ToString();
            }

            listView_books.View = View.LargeIcon;
            imageList_BookCovers.ImageSize = new Size(200, 250);
            listView_books.LargeImageList = imageList_BookCovers;


            //loop to display the data in the listview
            for (int j = 0; j < imageList_BookCovers.Images.Count; j++)
            {
                listView_books.Items.Add(new ListViewItem() { Text = titles[j], ImageIndex = j });
            }

        }

        private void listView_books_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
