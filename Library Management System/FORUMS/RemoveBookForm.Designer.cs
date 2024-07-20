namespace Library_Management_System.FORUMS
{
    partial class RemoveBookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown_BookId = new System.Windows.Forms.NumericUpDown();
            this.button_RemoveBook = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label_close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BookId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(0, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Remove Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.numericUpDown_BookId);
            this.panel1.Controls.Add(this.button_RemoveBook);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Location = new System.Drawing.Point(2, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 167);
            this.panel1.TabIndex = 2;
            // 
            // numericUpDown_BookId
            // 
            this.numericUpDown_BookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_BookId.Location = new System.Drawing.Point(229, 36);
            this.numericUpDown_BookId.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_BookId.Name = "numericUpDown_BookId";
            this.numericUpDown_BookId.Size = new System.Drawing.Size(200, 31);
            this.numericUpDown_BookId.TabIndex = 55;
            this.numericUpDown_BookId.ValueChanged += new System.EventHandler(this.numericUpDown_BookId_ValueChanged);
            // 
            // button_RemoveBook
            // 
            this.button_RemoveBook.BackColor = System.Drawing.Color.Crimson;
            this.button_RemoveBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_RemoveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveBook.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_RemoveBook.ForeColor = System.Drawing.Color.White;
            this.button_RemoveBook.Location = new System.Drawing.Point(59, 102);
            this.button_RemoveBook.Name = "button_RemoveBook";
            this.button_RemoveBook.Size = new System.Drawing.Size(370, 42);
            this.button_RemoveBook.TabIndex = 54;
            this.button_RemoveBook.Text = "Remove This Book";
            this.button_RemoveBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_RemoveBook.UseVisualStyleBackColor = false;
            this.button_RemoveBook.Click += new System.EventHandler(this.button_RemoveBook_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label33.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label33.Location = new System.Drawing.Point(55, 39);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(168, 24);
            this.label33.TabIndex = 52;
            this.label33.Text = "Enter The Book ID:";
            this.label33.Click += new System.EventHandler(this.label33_Click);
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Yellow;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Silver;
            this.label_close.Location = new System.Drawing.Point(456, 3);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(22, 23);
            this.label_close.TabIndex = 3;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            // 
            // RemoveBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(478, 222);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveBookForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BookId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Button button_RemoveBook;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.NumericUpDown numericUpDown_BookId;
    }
}