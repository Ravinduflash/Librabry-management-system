namespace Library_Management_System.FORUMS
{
    partial class Login_Form
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_login = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.pictureBox_Pass = new System.Windows.Forms.PictureBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.label_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.pictureBox_Pass);
            this.panel1.Controls.Add(this.textBox_username);
            this.panel1.Controls.Add(this.pictureBox_User);
            this.panel1.Controls.Add(this.label_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 334);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(31, 267);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(366, 42);
            this.button_login.TabIndex = 6;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(117, 198);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(280, 44);
            this.textBox_password.TabIndex = 5;
            this.textBox_password.Text = "12345";
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // pictureBox_Pass
            // 
            this.pictureBox_Pass.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_Pass.ImageLocation = "D:\\lectures\\BIT\\SEM 2\\project\\LMS 2.0\\Library Management System\\Library Managemen" +
    "t System\\IMAGES\\key.png";
            this.pictureBox_Pass.Location = new System.Drawing.Point(31, 187);
            this.pictureBox_Pass.Name = "pictureBox_Pass";
            this.pictureBox_Pass.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_Pass.TabIndex = 4;
            this.pictureBox_Pass.TabStop = false;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(117, 111);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(280, 44);
            this.textBox_username.TabIndex = 3;
            this.textBox_username.Text = "Enter User Name";
            this.textBox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.BackColor = System.Drawing.Color.Silver;
            this.pictureBox_User.ErrorImage = null;
            this.pictureBox_User.ImageLocation = "D:\\lectures\\BIT\\SEM 2\\project\\LMS 2.0\\Library Management System\\Library Managemen" +
    "t System\\IMAGES\\user.png";
            this.pictureBox_User.Location = new System.Drawing.Point(31, 100);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(64, 64);
            this.pictureBox_User.TabIndex = 2;
            this.pictureBox_User.TabStop = false;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Yellow;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Silver;
            this.label_close.Location = new System.Drawing.Point(407, 1);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(22, 23);
            this.label_close.TabIndex = 1;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 334);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.PictureBox pictureBox_Pass;
    }
}