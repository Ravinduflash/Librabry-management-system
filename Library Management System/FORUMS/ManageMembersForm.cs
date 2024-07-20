using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.FORUMS
{
    public partial class ManageMembersForm : Form
    {
        public ManageMembersForm()
        {
            InitializeComponent();
        }

        CLASSES.MEMBER member = new CLASSES.MEMBER();

        private void pictureBox_cover_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageMembersForm_Load(object sender, EventArgs e)
        {
            //display header image
            pictureBox_authors.Image = Image.FromFile("../../IMAGES/typewriter.png");

            //display button images
            button_add.Image = Image.FromFile("../../IMAGES/plus.png");
            button_edit.Image = Image.FromFile("../../IMAGES/update.png");
            button_delete.Image = Image.FromFile("../../IMAGES/trash.png");
            button_selectPicture.Image = Image.FromFile("../../IMAGES/upload.png");
            button_ClearFields.Image = Image.FromFile("../../IMAGES/circle.png");

            //customize the datagridview rows height
            dataGridView_members.RowTemplate.Height = 60;
            
            
            //populate datagridview with Members

            dataGridView_members.DataSource = member.MembersList(true);

            

            
              
            //customize the datagridview image column
            DataGridViewImageColumn dgvImgCol = new DataGridViewImageColumn();
            dgvImgCol = (DataGridViewImageColumn)dataGridView_members.Columns[5];
            dgvImgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;


            //customize datagridview header
            dataGridView_members.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_members.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            dataGridView_members.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_members.EnableHeadersVisualStyles = false;

            
            //show the numer of members
            label_membersCount.Text = member.MembersList(true).Rows.Count.ToString() + " Members";
            
        }

        //browse and display the member picture.
        private void button_selectPicture_Click(object sender, EventArgs e)
        {

        }

        //button add a new member
        private void button_add_Click(object sender, EventArgs e)
        {
            
            string first_name = textBox_fname.Text;
            string last_name = textBox_lname.Text;
            string phone = textBox_phone.Text;
            string email = textBox_email.Text;
            string gender = "Male";//by default

            if (radioButton_Female.Checked)
            {
                gender = "Female";
            }

            MemoryStream ms = new MemoryStream();
            pictureBox_picture.Image.Save(ms, pictureBox_picture.Image.RawFormat);
            byte[] profile_picture = ms.ToArray();

            // check if the first/last name are empty.
            if (first_name.Trim().Equals("") || last_name.Trim().Equals("") || phone.Trim().Equals(""))
            {
                MessageBox.Show("You Need To Enter The Member Required Fields", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (member.addMember(first_name, last_name, gender, phone, email, profile_picture))
                {
                    MessageBox.Show("New Member Added Successfully", "New Member", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    //update the numer of members
                    label_membersCount.Text = member.MembersList(true).Rows.Count.ToString() + " Members";

                }
                else
                {
                    MessageBox.Show("Member Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_selectPicture_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            // image types
            opf.Filter = " Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                // display image in the pictureBox
                pictureBox_picture.Image = Image.FromFile(opf.FileName);
            }
        }

        //change radiobutton color checked on Male or female - male
        private void radioButton_Male_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Male.ForeColor = Color.Blue;
            radioButton_Female.ForeColor = Color.Black;
        }
        //change radiobutton color checked on Male or female - female
        private void radioButton_Female_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Male.ForeColor = Color.Black;
            radioButton_Female.ForeColor = Color.Blue;
        }

        // button edit the selected member
        private void button_edit_Click(object sender, EventArgs e)
        {
            int id;
            string first_name = textBox_fname.Text;
            string last_name = textBox_lname.Text;
            string phone = textBox_phone.Text;
            string email = textBox_email.Text;
            string gender = "Male";//by default

            if (radioButton_Female.Checked)
            {
                gender = "Female";
            }

            MemoryStream ms = new MemoryStream();
            pictureBox_picture.Image.Save(ms, pictureBox_picture.Image.RawFormat);
            byte[] profile_picture = ms.ToArray();


            if (!textBox_id.Text.Trim().Equals(""))
            {
                id = Convert.ToInt32(textBox_id.Text);
            
                // check if the first/last name are empty.
                if (first_name.Trim().Equals("") || last_name.Trim().Equals("") || phone.Trim().Equals(""))
                {
                    MessageBox.Show("You Need To Enter The Member Required Fields", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (member.editMember(id, first_name, last_name, gender, phone, email, profile_picture))
                    {//
                        MessageBox.Show("Member Data Edited Successfully", "Edit Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //
                        
                        //update the numer of members
                        label_membersCount.Text = member.MembersList(true).Rows.Count.ToString() + " Members";

                    }
                    else
                    {
                        MessageBox.Show("Member Data Not Edited", "Edit-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Select the Member From The Table First", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


          
        }

        // button remove the selected member
        private void button_delete_Click(object sender, EventArgs e)

        {
            int id;
            if (!textBox_id.Text.Trim().Equals(""))
            {
                id = Convert.ToInt32(textBox_id.Text);

                // we need to show a confirmation message before delete the member
                if (MessageBox.Show("Do You Want to Delete This Member?", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (member.removeMember(id))
                    {
                        MessageBox.Show("Member Data Deleted Successfully", "Remove Member", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        //update the numer of members
                        label_membersCount.Text = member.MembersList(true).Rows.Count.ToString() + " Members";

                        //we need to clear the fields after the member is deleted
                        //we will call the button clear
                        button_ClearFields.PerformClick();


                    }
                    else
                    {
                        MessageBox.Show("Member Data Not Deleted, Check If This ID Exists", "Remove Member", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                 
                if (member.removeMember(id))
                {
                    MessageBox.Show("Member Data Deleted Successfully", "Remove Member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    
                    //update the numer of members
                    label_membersCount.Text = member.MembersList(true).Rows.Count.ToString() + " Members";
                }
                else
                {
                    MessageBox.Show("Member Data Not Deleted, Check If This ID Exists", "Remove Member", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Select the Member From The Table First", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
                
            
        }

        // display the selected member data
        private void dataGridView_members_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_members.CurrentRow.Cells[0].Value.ToString();

            // get the first and last name from the fullname column.
            string fullname = dataGridView_members.CurrentRow.Cells[1].Value.ToString();
            var first_and_last_name = fullname.Split('-');
            textBox_fname.Text = first_and_last_name[0];
            textBox_lname.Text = first_and_last_name[1];
            
            string gender = dataGridView_members.CurrentRow.Cells[2].Value.ToString();
            if (gender.Equals("Male"))
            {
                radioButton_Male.Checked = true;
            }
            else
            {
                radioButton_Female.Checked = true;
            }

            textBox_phone.Text = dataGridView_members.CurrentRow.Cells[3].Value.ToString();
            textBox_email.Text = dataGridView_members.CurrentRow.Cells[4].Value.ToString();

            byte[] pic = (byte[]) dataGridView_members.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(pic);
            pictureBox_picture.Image = Image.FromStream(ms);

        }

        //button to clear all fields
        private void button_ClearFields_Click(object sender, EventArgs e)
        {
            textBox_id.Text = "";
            textBox_fname.Text = "";
            textBox_lname.Text = "";
            radioButton_Male.Checked = true;
            textBox_phone.Text = "";
            textBox_email.Text = "";
            pictureBox_picture.ImageLocation = "../../IMAGES/avatar.png";
        }

        //button refresh the datagridview with the new data

        private void button_refresh_Click(object sender, EventArgs e)
        {
            //refresh datagridview
            dataGridView_members.DataSource = member.MembersList(true);

        }

        private void label_membersCount_Click(object sender, EventArgs e)
        {

        }
    }
}
