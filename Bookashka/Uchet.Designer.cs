namespace Bookashka
{
    partial class Uchet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uchet));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("");
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewUchet = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bibl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdBibl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdChit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Book = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxBibl = new System.Windows.Forms.ComboBox();
            this.comboBoxChit = new System.Windows.Forms.ComboBox();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.labelBibl = new System.Windows.Forms.Label();
            this.labelChit = new System.Windows.Forms.Label();
            this.labelBook = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-12, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 148);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // listViewUchet
            // 
            this.listViewUchet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Bibl,
            this.IdBibl,
            this.Chit,
            this.IdChit,
            this.Book});
            this.listViewUchet.HideSelection = false;
            listViewItem7.Tag = "Id";
            listViewItem8.IndentCount = 1;
            listViewItem8.Tag = "FirstName";
            listViewItem9.Tag = "MiddleName";
            listViewItem10.Tag = "LastName";
            listViewItem11.Tag = "Phone";
            listViewItem12.Tag = "Email";
            this.listViewUchet.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listViewUchet.Location = new System.Drawing.Point(205, 133);
            this.listViewUchet.Name = "listViewUchet";
            this.listViewUchet.Size = new System.Drawing.Size(583, 244);
            this.listViewUchet.TabIndex = 58;
            this.listViewUchet.UseCompatibleStateImageBehavior = false;
            this.listViewUchet.View = System.Windows.Forms.View.Details;
            this.listViewUchet.SelectedIndexChanged += new System.EventHandler(this.listViewUchet_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Tag = "Id";
            this.ID.Text = "ID";
            this.ID.Width = 31;
            // 
            // Bibl
            // 
            this.Bibl.Tag = "Bibl";
            this.Bibl.Text = "Библиотекарь";
            this.Bibl.Width = 105;
            // 
            // IdBibl
            // 
            this.IdBibl.Tag = "IdBibl";
            this.IdBibl.Text = "Id библиотекаря";
            this.IdBibl.Width = 92;
            // 
            // Chit
            // 
            this.Chit.Tag = "Chit";
            this.Chit.Text = "Читатель";
            this.Chit.Width = 79;
            // 
            // IdChit
            // 
            this.IdChit.Tag = "IdChit";
            this.IdChit.Text = "Id читателя";
            // 
            // Book
            // 
            this.Book.Tag = "Book";
            this.Book.Text = "Книга";
            // 
            // comboBoxBibl
            // 
            this.comboBoxBibl.FormattingEnabled = true;
            this.comboBoxBibl.Location = new System.Drawing.Point(1, 160);
            this.comboBoxBibl.Name = "comboBoxBibl";
            this.comboBoxBibl.Size = new System.Drawing.Size(181, 21);
            this.comboBoxBibl.TabIndex = 64;
            // 
            // comboBoxChit
            // 
            this.comboBoxChit.FormattingEnabled = true;
            this.comboBoxChit.Location = new System.Drawing.Point(1, 234);
            this.comboBoxChit.Name = "comboBoxChit";
            this.comboBoxChit.Size = new System.Drawing.Size(181, 21);
            this.comboBoxChit.TabIndex = 63;
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(1, 312);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(181, 21);
            this.comboBoxBook.TabIndex = 62;
            // 
            // labelBibl
            // 
            this.labelBibl.AutoSize = true;
            this.labelBibl.Location = new System.Drawing.Point(-2, 144);
            this.labelBibl.Name = "labelBibl";
            this.labelBibl.Size = new System.Drawing.Size(79, 13);
            this.labelBibl.TabIndex = 61;
            this.labelBibl.Text = "Библиотекарь";
            // 
            // labelChit
            // 
            this.labelChit.AutoSize = true;
            this.labelChit.Location = new System.Drawing.Point(-2, 218);
            this.labelChit.Name = "labelChit";
            this.labelChit.Size = new System.Drawing.Size(55, 13);
            this.labelChit.TabIndex = 60;
            this.labelChit.Text = "Читатель";
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Location = new System.Drawing.Point(-2, 296);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(37, 13);
            this.labelBook.TabIndex = 59;
            this.labelBook.Text = "Книга";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(474, 383);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 65;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(583, 383);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 66;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDel.Location = new System.Drawing.Point(690, 383);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 67;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Uchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxBibl);
            this.Controls.Add(this.comboBoxChit);
            this.Controls.Add(this.comboBoxBook);
            this.Controls.Add(this.labelBibl);
            this.Controls.Add(this.labelChit);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.listViewUchet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Uchet";
            this.Text = "Uchet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewUchet;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ComboBox comboBoxBibl;
        private System.Windows.Forms.ComboBox comboBoxChit;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.Label labelBibl;
        private System.Windows.Forms.Label labelChit;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ColumnHeader Bibl;
        private System.Windows.Forms.ColumnHeader IdBibl;
        private System.Windows.Forms.ColumnHeader Chit;
        private System.Windows.Forms.ColumnHeader IdChit;
        private System.Windows.Forms.ColumnHeader Book;
    }
}