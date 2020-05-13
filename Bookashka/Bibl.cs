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
    public partial class Bibl : Form
    {
        public Bibl()
        {
            InitializeComponent();
            ShowClient();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BiblSet biblSet = new BiblSet();

            biblSet.FirstName = textBoxFirstName.Text;
            biblSet.MiddleName = textBoxMiddleName.Text;
            biblSet.LastName = textBoxLastName.Text;
            biblSet.Phone = textBoxPhone.Text;
            biblSet.Email = textBoxEmail.Text;

            Program.wftDb.BiblSet.Add(biblSet);

            Program.wftDb.SaveChanges();
            ShowClient();
        }
        void ShowClient()
        {
            listViewBibl.Items.Clear();

            foreach (BiblSet biblSet in Program.wftDb.BiblSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    biblSet.Id.ToString(), biblSet.FirstName, biblSet.MiddleName, biblSet.LastName, biblSet.Phone, biblSet.Email
                });
                item.Tag = biblSet;

                listViewBibl.Items.Add(item);
            }
            listViewBibl.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewBibl.SelectedItems.Count == 1)
            {
                BiblSet biblSet = listViewBibl.SelectedItems[0].Tag as BiblSet;
                biblSet.FirstName = textBoxFirstName.Text;
                biblSet.MiddleName = textBoxMiddleName.Text;
                biblSet.LastName = textBoxLastName.Text;
                biblSet.Phone = textBoxPhone.Text;
                biblSet.Email = textBoxEmail.Text;
                Program.wftDb.SaveChanges();
                ShowClient();
            }
        }

        private void listViewBibl_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewBibl.SelectedItems.Count == 1)
            {
                BiblSet biblSet = listViewBibl.SelectedItems[0].Tag as BiblSet;
                biblSet.FirstName = textBoxFirstName.Text;
                biblSet.MiddleName = textBoxMiddleName.Text;
                biblSet.LastName = textBoxLastName.Text;
                biblSet.Phone = textBoxPhone.Text;
                biblSet.Email = textBoxEmail.Text;
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
                if (listViewBibl.SelectedItems.Count == 1)
                {
                    BiblSet biblSet = listViewBibl.SelectedItems[0].Tag as BiblSet;
                    Program.wftDb.BiblSet.Remove(biblSet);
                    Program.wftDb.SaveChanges();
                    ShowClient();
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
    

