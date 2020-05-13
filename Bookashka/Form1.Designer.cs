namespace Bookashka
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenBibl = new System.Windows.Forms.Button();
            this.buttonOpenChit = new System.Windows.Forms.Button();
            this.buttonOpenBook = new System.Windows.Forms.Button();
            this.buttonOpenUchet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-17, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenBibl
            // 
            this.buttonOpenBibl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpenBibl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenBibl.Location = new System.Drawing.Point(12, 150);
            this.buttonOpenBibl.Name = "buttonOpenBibl";
            this.buttonOpenBibl.Size = new System.Drawing.Size(372, 44);
            this.buttonOpenBibl.TabIndex = 1;
            this.buttonOpenBibl.Text = "Библиотекари";
            this.buttonOpenBibl.UseVisualStyleBackColor = false;
            this.buttonOpenBibl.Click += new System.EventHandler(this.buttonOpenBibl_Click);
            // 
            // buttonOpenChit
            // 
            this.buttonOpenChit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpenChit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenChit.Location = new System.Drawing.Point(12, 224);
            this.buttonOpenChit.Name = "buttonOpenChit";
            this.buttonOpenChit.Size = new System.Drawing.Size(372, 44);
            this.buttonOpenChit.TabIndex = 2;
            this.buttonOpenChit.Text = "Читатели";
            this.buttonOpenChit.UseVisualStyleBackColor = false;
            this.buttonOpenChit.Click += new System.EventHandler(this.buttonOpenChit_Click);
            // 
            // buttonOpenBook
            // 
            this.buttonOpenBook.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpenBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenBook.Location = new System.Drawing.Point(12, 294);
            this.buttonOpenBook.Name = "buttonOpenBook";
            this.buttonOpenBook.Size = new System.Drawing.Size(372, 44);
            this.buttonOpenBook.TabIndex = 3;
            this.buttonOpenBook.Text = "Книги";
            this.buttonOpenBook.UseVisualStyleBackColor = false;
            this.buttonOpenBook.Click += new System.EventHandler(this.buttonOpenBook_Click);
            // 
            // buttonOpenUchet
            // 
            this.buttonOpenUchet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpenUchet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOpenUchet.Location = new System.Drawing.Point(12, 360);
            this.buttonOpenUchet.Name = "buttonOpenUchet";
            this.buttonOpenUchet.Size = new System.Drawing.Size(372, 44);
            this.buttonOpenUchet.TabIndex = 4;
            this.buttonOpenUchet.Text = "Учет";
            this.buttonOpenUchet.UseVisualStyleBackColor = false;
            this.buttonOpenUchet.Click += new System.EventHandler(this.buttonOpenUchet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.buttonOpenUchet);
            this.Controls.Add(this.buttonOpenBook);
            this.Controls.Add(this.buttonOpenChit);
            this.Controls.Add(this.buttonOpenBibl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOpenBibl;
        private System.Windows.Forms.Button buttonOpenChit;
        private System.Windows.Forms.Button buttonOpenBook;
        private System.Windows.Forms.Button buttonOpenUchet;
    }
}

