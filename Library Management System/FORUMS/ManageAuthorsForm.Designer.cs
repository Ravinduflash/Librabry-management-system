namespace Library_Management_System.FORUMS
{
    partial class ManageAuthorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAuthorsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox_bio = new System.Windows.Forms.RichTextBox();
            this.dataGridView_authors = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_education = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_ClearFields = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label_authorsCount = new System.Windows.Forms.Label();
            this.button_Show_Author_Books = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_authors = new System.Windows.Forms.PictureBox();
            this.label_close = new System.Windows.Forms.Label();
            this.label_header = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authors)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_authors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 501);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.richTextBox_bio);
            this.panel4.Controls.Add(this.dataGridView_authors);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.textBox_education);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.textBox_lname);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.textBox_fname);
            this.panel4.Controls.Add(this.textBox_id);
            this.panel4.Controls.Add(this.label_name);
            this.panel4.Controls.Add(this.label_id);
            this.panel4.Location = new System.Drawing.Point(160, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(951, 415);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // richTextBox_bio
            // 
            this.richTextBox_bio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_bio.Location = new System.Drawing.Point(120, 225);
            this.richTextBox_bio.Name = "richTextBox_bio";
            this.richTextBox_bio.Size = new System.Drawing.Size(239, 181);
            this.richTextBox_bio.TabIndex = 17;
            this.richTextBox_bio.Text = "";
            this.richTextBox_bio.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // dataGridView_authors
            // 
            this.dataGridView_authors.AllowUserToAddRows = false;
            this.dataGridView_authors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_authors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_authors.Location = new System.Drawing.Point(382, 37);
            this.dataGridView_authors.Name = "dataGridView_authors";
            this.dataGridView_authors.Size = new System.Drawing.Size(549, 369);
            this.dataGridView_authors.TabIndex = 16;
            this.dataGridView_authors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_authors_CellClick);
            this.dataGridView_authors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_authors_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(18, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Little Bio:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_education
            // 
            this.textBox_education.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_education.Location = new System.Drawing.Point(120, 178);
            this.textBox_education.Name = "textBox_education";
            this.textBox_education.Size = new System.Drawing.Size(239, 29);
            this.textBox_education.TabIndex = 13;
            this.textBox_education.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(7, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Education:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_lname
            // 
            this.textBox_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lname.Location = new System.Drawing.Point(120, 131);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(239, 29);
            this.textBox_lname.TabIndex = 11;
            this.textBox_lname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(7, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Last Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_fname
            // 
            this.textBox_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fname.Location = new System.Drawing.Point(120, 84);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(239, 29);
            this.textBox_fname.TabIndex = 9;
            this.textBox_fname.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(120, 37);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(137, 29);
            this.textBox_id.TabIndex = 8;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_name.Location = new System.Drawing.Point(7, 84);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(107, 24);
            this.label_name.TabIndex = 7;
            this.label_name.Text = "First Name:";
            this.label_name.Click += new System.EventHandler(this.label_name_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_id.Location = new System.Drawing.Point(78, 37);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(34, 24);
            this.label_id.TabIndex = 6;
            this.label_id.Text = "ID:";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.button_ClearFields);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label_authorsCount);
            this.panel3.Controls.Add(this.button_Show_Author_Books);
            this.panel3.Controls.Add(this.button_delete);
            this.panel3.Controls.Add(this.button_edit);
            this.panel3.Controls.Add(this.button_add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 420);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button_ClearFields
            // 
            this.button_ClearFields.BackColor = System.Drawing.Color.White;
            this.button_ClearFields.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_ClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClearFields.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClearFields.Image = ((System.Drawing.Image)(resources.GetObject("button_ClearFields.Image")));
            this.button_ClearFields.Location = new System.Drawing.Point(2, 300);
            this.button_ClearFields.Name = "button_ClearFields";
            this.button_ClearFields.Size = new System.Drawing.Size(155, 48);
            this.button_ClearFields.TabIndex = 54;
            this.button_ClearFields.Text = "  Clear";
            this.button_ClearFields.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ClearFields.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ClearFields.UseVisualStyleBackColor = false;
            this.button_ClearFields.Click += new System.EventHandler(this.button_ClearFields_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 52);
            this.button1.TabIndex = 53;
            this.button1.Text = "Export Authors To Txt File";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label_authorsCount
            // 
            this.label_authorsCount.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_authorsCount.ForeColor = System.Drawing.Color.Gold;
            this.label_authorsCount.Location = new System.Drawing.Point(1, 362);
            this.label_authorsCount.Name = "label_authorsCount";
            this.label_authorsCount.Size = new System.Drawing.Size(160, 41);
            this.label_authorsCount.TabIndex = 52;
            this.label_authorsCount.Text = "99 Authors";
            this.label_authorsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_authorsCount.Click += new System.EventHandler(this.label_authorsCount_Click);
            // 
            // button_Show_Author_Books
            // 
            this.button_Show_Author_Books.BackColor = System.Drawing.Color.White;
            this.button_Show_Author_Books.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_Show_Author_Books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Show_Author_Books.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Show_Author_Books.Image = ((System.Drawing.Image)(resources.GetObject("button_Show_Author_Books.Image")));
            this.button_Show_Author_Books.Location = new System.Drawing.Point(3, 188);
            this.button_Show_Author_Books.Name = "button_Show_Author_Books";
            this.button_Show_Author_Books.Size = new System.Drawing.Size(155, 52);
            this.button_Show_Author_Books.TabIndex = 9;
            this.button_Show_Author_Books.Text = "Show Author Books";
            this.button_Show_Author_Books.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Show_Author_Books.UseVisualStyleBackColor = false;
            this.button_Show_Author_Books.Click += new System.EventHandler(this.button_Show_Author_Books_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.White;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.Image")));
            this.button_delete.Location = new System.Drawing.Point(3, 136);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(155, 47);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "    Delete";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.White;
            this.button_edit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Image = ((System.Drawing.Image)(resources.GetObject("button_edit.Image")));
            this.button_edit.Location = new System.Drawing.Point(3, 84);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(155, 47);
            this.button_edit.TabIndex = 7;
            this.button_edit.Text = "  Edit";
            this.button_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Image = ((System.Drawing.Image)(resources.GetObject("button_add.Image")));
            this.button_add.Location = new System.Drawing.Point(3, 32);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(155, 47);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "  Add";
            this.button_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(144)))));
            this.panel2.Controls.Add(this.pictureBox_authors);
            this.panel2.Controls.Add(this.label_close);
            this.panel2.Controls.Add(this.label_header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 81);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox_authors
            // 
            this.pictureBox_authors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(144)))));
            this.pictureBox_authors.ImageLocation = "../../IMAGES/typewriter.png";
            this.pictureBox_authors.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_authors.Name = "pictureBox_authors";
            this.pictureBox_authors.Size = new System.Drawing.Size(81, 81);
            this.pictureBox_authors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_authors.TabIndex = 0;
            this.pictureBox_authors.TabStop = false;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(1093, 1);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(22, 23);
            this.label_close.TabIndex = 3;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // label_header
            // 
            this.label_header.BackColor = System.Drawing.Color.Transparent;
            this.label_header.Font = new System.Drawing.Font("Adobe Gothic Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_header.ForeColor = System.Drawing.Color.White;
            this.label_header.Location = new System.Drawing.Point(81, 1);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(154, 77);
            this.label_header.TabIndex = 1;
            this.label_header.Text = "Authors";
            this.label_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManageAuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 501);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAuthorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAuthorsForm";
            this.Load += new System.EventHandler(this.ManageAuthorsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_authors)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_authors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_authors;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_education;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_authors;
        private System.Windows.Forms.RichTextBox richTextBox_bio;
        private System.Windows.Forms.Button button_Show_Author_Books;
        private System.Windows.Forms.Label label_authorsCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_ClearFields;
    }
}