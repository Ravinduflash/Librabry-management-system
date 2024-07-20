namespace Library_Management_System.FORUMS
{
    partial class BookListForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Close_ = new System.Windows.Forms.Label();
            this.label_author = new System.Windows.Forms.Label();
            this.listView_books = new System.Windows.Forms.ListView();
            this.label_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList_BookCovers = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_Close_);
            this.panel1.Controls.Add(this.label_author);
            this.panel1.Controls.Add(this.listView_books);
            this.panel1.Controls.Add(this.label_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 507);
            this.panel1.TabIndex = 1;
            // 
            // label_Close_
            // 
            this.label_Close_.BackColor = System.Drawing.Color.Yellow;
            this.label_Close_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Close_.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Close_.ForeColor = System.Drawing.Color.Black;
            this.label_Close_.Location = new System.Drawing.Point(299, 0);
            this.label_Close_.Name = "label_Close_";
            this.label_Close_.Size = new System.Drawing.Size(22, 23);
            this.label_Close_.TabIndex = 3;
            this.label_Close_.Text = "X";
            this.label_Close_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Close_.Click += new System.EventHandler(this.label_Close__Click);
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.BackColor = System.Drawing.Color.Transparent;
            this.label_author.Font = new System.Drawing.Font("Adobe Gothic Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_author.ForeColor = System.Drawing.Color.Navy;
            this.label_author.Location = new System.Drawing.Point(3, 74);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(273, 24);
            this.label_author.TabIndex = 3;
            this.label_author.Text = "books by: the author full name";
            // 
            // listView_books
            // 
            this.listView_books.BackColor = System.Drawing.Color.Gray;
            this.listView_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_books.ForeColor = System.Drawing.Color.White;
            this.listView_books.Location = new System.Drawing.Point(3, 103);
            this.listView_books.Name = "listView_books";
            this.listView_books.Size = new System.Drawing.Size(313, 399);
            this.listView_books.TabIndex = 2;
            this.listView_books.UseCompatibleStateImageBehavior = false;
            this.listView_books.SelectedIndexChanged += new System.EventHandler(this.listView_books_SelectedIndexChanged);
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.Yellow;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_close.ForeColor = System.Drawing.Color.Silver;
            this.label_close.Location = new System.Drawing.Point(406, 1);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(22, 23);
            this.label_close.TabIndex = 1;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author Books";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList_BookCovers
            // 
            this.imageList_BookCovers.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_BookCovers.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList_BookCovers.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BookListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 507);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookListForm";
            this.Load += new System.EventHandler(this.BookListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.ListView listView_books;
        private System.Windows.Forms.ImageList imageList_BookCovers;
        private System.Windows.Forms.Label label_Close_;
    }
}