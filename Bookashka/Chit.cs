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
    public partial class Chit : Form
    {
        public Chit()
        {
            InitializeComponent();
            ShowChit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ChitSet chitSet = new ChitSet();

            chitSet.FirstName = textBoxFirstName.Text;
            chitSet.MiddleName = textBoxMiddleName.Text;
            chitSet.LastName = textBoxLastName.Text;
            chitSet.Phone = textBoxPhone.Text;
            chitSet.Email = textBoxEmail.Text;

            Program.wftDb.ChitSet.Add(chitSet);

            Program.wftDb.SaveChanges();
            ShowChit();
        }
        void ShowChit()
        {
            listViewChit.Items.Clear();

            foreach (ChitSet chitSet in Program.wftDb.ChitSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    chitSet.Id.ToString(), chitSet.FirstName, chitSet.MiddleName, chitSet.LastName, chitSet.Phone, chitSet.Email
                });
                item.Tag = chitSet;

                listViewChit.Items.Add(item);
            }
            listViewChit.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewChit.SelectedItems.Count == 1)
            {
                ChitSet chitSet = listViewChit.SelectedItems[0].Tag as ChitSet;
                chitSet.FirstName = textBoxFirstName.Text;
                chitSet.MiddleName = textBoxMiddleName.Text;
                chitSet.LastName = textBoxLastName.Text;
                chitSet.Phone = textBoxPhone.Text;
                chitSet.Email = textBoxEmail.Text;
                Program.wftDb.SaveChanges();
                ShowChit();
            }
        }

        private void listViewChit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewChit.SelectedItems.Count == 1)
            {
                ChitSet chitSet = listViewChit.SelectedItems[0].Tag as ChitSet;
                chitSet.FirstName = textBoxFirstName.Text;
                chitSet.MiddleName = textBoxMiddleName.Text;
                chitSet.LastName = textBoxLastName.Text;
                chitSet.Phone = textBoxPhone.Text;
                chitSet.Email = textBoxEmail.Text;
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewChit.SelectedItems.Count == 1)
                {
                    ChitSet chitSet = listViewChit.SelectedItems[0].Tag as ChitSet;
                    Program.wftDb.ChitSet.Remove(chitSet);
                    Program.wftDb.SaveChanges();
                    ShowChit();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
