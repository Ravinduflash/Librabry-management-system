namespace Library_Management_System.FORUMS
{
    partial class MangeGenresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MangeGenresForm));
            this.label_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_close = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.dataGridView_genres = new System.Windows.Forms.DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_genres)).BeginInit();
            this.SuspendLayout();
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
            this.label_header.Text = "Genres";
            this.label_header.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_edit);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.dataGridView_genres);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Location = new System.Drawing.Point(5, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 365);
            this.panel1.TabIndex = 2;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Transparent;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.White;
            this.label_close.Location = new System.Drawing.Point(808, 2);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(22, 23);
            this.label_close.TabIndex = 3;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label_close);
            this.panel2.Controls.Add(this.label_header);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 81);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.ImageLocation = "../../IMAGES/genres.png";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(43, 69);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(39, 26);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID:";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Adobe Gothic Std B", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(6, 112);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(76, 26);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Name:";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(88, 67);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(137, 29);
            this.textBox_id.TabIndex = 2;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(90, 112);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(261, 29);
            this.textBox_name.TabIndex = 3;
            // 
            // dataGridView_genres
            // 
            this.dataGridView_genres.AllowUserToAddRows = false;
            this.dataGridView_genres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_genres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_genres.Location = new System.Drawing.Point(378, 28);
            this.dataGridView_genres.Name = "dataGridView_genres";
            this.dataGridView_genres.Size = new System.Drawing.Size(420, 312);
            this.dataGridView_genres.TabIndex = 4;
            this.dataGridView_genres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_genres_CellClick);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.White;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Image = ((System.Drawing.Image)(resources.GetObject("button_add.Image")));
            this.button_add.Location = new System.Drawing.Point(23, 291);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(103, 36);
            this.button_add.TabIndex = 5;
            this.button_add.Text = "  Add";
            this.button_add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.White;
            this.button_edit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Image = ((System.Drawing.Image)(resources.GetObject("button_edit.Image")));
            this.button_edit.Location = new System.Drawing.Point(132, 291);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(103, 36);
            this.button_edit.TabIndex = 6;
            this.button_edit.Text = "  Edit";
            this.button_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.White;
            this.button_delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.Image")));
            this.button_delete.Location = new System.Drawing.Point(241, 291);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(105, 36);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "  Delete";
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // MangeGenresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(832, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MangeGenresForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MangeGenresForm";
            this.Load += new System.EventHandler(this.ManageGenresForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_genres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView_genres;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
    }
}