namespace Bookashka
{
    partial class Chit
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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chit));
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.listViewChit = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Имя = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Отчество = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Фамилия = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Телефон = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Почта = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(-2, 344);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(37, 13);
            this.labelEmail.TabIndex = 61;
            this.labelEmail.Text = "Почта";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(-4, 300);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(52, 13);
            this.labelPhone.TabIndex = 60;
            this.labelPhone.Text = "Телефон";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(-4, 255);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(56, 13);
            this.labelLastName.TabIndex = 59;
            this.labelLastName.Text = "Фамилия";
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(-2, 207);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(54, 13);
            this.labelMiddleName.TabIndex = 58;
            this.labelMiddleName.Text = "Отчество";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(-2, 160);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 57;
            this.labelFirstName.Text = "Имя";
            // 
            // listViewChit
            // 
            this.listViewChit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Имя,
            this.Отчество,
            this.Фамилия,
            this.Телефон,
            this.Почта});
            this.listViewChit.HideSelection = false;
            listViewItem7.Tag = "Id";
            listViewItem8.IndentCount = 1;
            listViewItem8.Tag = "FirstName";
            listViewItem9.Tag = "MiddleName";
            listViewItem10.Tag = "LastName";
            listViewItem11.Tag = "Phone";
            listViewItem12.Tag = "Email";
            this.listViewChit.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.listViewChit.Location = new System.Drawing.Point(205, 160);
            this.listViewChit.Name = "listViewChit";
            this.listViewChit.Size = new System.Drawing.Size(583, 244);
            this.listViewChit.TabIndex = 56;
            this.listViewChit.UseCompatibleStateImageBehavior = false;
            this.listViewChit.View = System.Windows.Forms.View.Details;
            this.listViewChit.SelectedIndexChanged += new System.EventHandler(this.listViewChit_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Tag = "Id";
            this.ID.Text = "ID";
            // 
            // Имя
            // 
            this.Имя.Tag = "FirstName";
            this.Имя.Text = "Имя";
            // 
            // Отчество
            // 
            this.Отчество.Tag = "MiddleName";
            this.Отчество.Text = "Отчество";
            // 
            // Фамилия
            // 
            this.Фамилия.Tag = "LastName";
            this.Фамилия.Text = "Фамилия";
            // 
            // Телефон
            // 
            this.Телефон.Tag = "Phone";
            this.Телефон.Text = "Телефон";
            // 
            // Почта
            // 
            this.Почта.Tag = "Email";
            this.Почта.Text = "Почта";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(1, 360);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(180, 20);
            this.textBoxEmail.TabIndex = 55;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(1, 316);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(180, 20);
            this.textBoxPhone.TabIndex = 54;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(1, 271);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(180, 20);
            this.textBoxLastName.TabIndex = 53;
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(1, 223);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(180, 20);
            this.textBoxMiddleName.TabIndex = 52;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(1, 176);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(180, 20);
            this.textBoxFirstName.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-15, -23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 148);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(469, 410);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 62;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(575, 410);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 63;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDel.Location = new System.Drawing.Point(679, 410);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 64;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // Chit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.listViewChit);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Chit";
            this.Text = "Chit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.ListView listViewChit;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Имя;
        private System.Windows.Forms.ColumnHeader Отчество;
        private System.Windows.Forms.ColumnHeader Фамилия;
        private System.Windows.Forms.ColumnHeader Телефон;
        private System.Windows.Forms.ColumnHeader Почта;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
    }
}