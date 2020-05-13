using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookashka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (Autorization.users.type == "bibl") buttonOpenBibl.Enabled = false;
        }

        private void buttonOpenBibl_Click(object sender, EventArgs e)
        {
            Form formBibl = new Bibl();
            formBibl.Show();
        }

        private void buttonOpenChit_Click(object sender, EventArgs e)
        {
            Form formChit = new Chit();
            formChit.Show();
        }

        private void buttonOpenBook_Click(object sender, EventArgs e)
        {
            Form formBook = new Book();
            formBook.Show();
        }

        private void buttonOpenUchet_Click(object sender, EventArgs e)
        {
            Form formUchet = new Uchet();
            formUchet.Show();
        }
    }
}
