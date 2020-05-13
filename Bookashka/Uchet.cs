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
    public partial class Uchet : Form
    {
        public Uchet()
        {
            InitializeComponent();
            ShowBibl();
            ShowChit();
            ShowBook();
            ShowUchet();
        }
        void ShowBibl()
        {
            comboBoxBibl.Items.Clear();
            foreach (BiblSet biblSet in Program.wftDb.BiblSet)
            {
                string[] item = { biblSet.Id.ToString() + ".", biblSet.FirstName, biblSet.MiddleName, biblSet.LastName };
                comboBoxBibl.Items.Add(string.Join(" ", item));
            }
        }
        void ShowChit()
        {
            comboBoxChit.Items.Clear();
            foreach (ChitSet chitSet in Program.wftDb.ChitSet)
            {
                string[] item = { chitSet.Id.ToString() + ".", chitSet.FirstName, chitSet.MiddleName, chitSet.LastName };
                comboBoxChit.Items.Add(string.Join(" ", item));
            }
        }
        void ShowBook()
        {
            comboBoxBook.Items.Clear();
            foreach (BookSet bookSet in Program.wftDb.BookSet)
            {
                string[] item = { bookSet.Id.ToString() + ".", bookSet.Name, bookSet.Genre, bookSet.Author };
                comboBoxBook.Items.Add(string.Join(" ", item));
            }
        }


        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            if (comboBoxBibl.SelectedItem != null && comboBoxChit.SelectedItem != null )
            {
                {
                    UchetSet supply = new UchetSet();
                    supply.IdBibl = Convert.ToInt32(comboBoxBibl.SelectedItem.ToString().Split('.')[0]);
                    supply.IdChit = Convert.ToInt32(comboBoxChit.SelectedItem.ToString().Split('.')[0]);
                    supply.IdBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                    Program.wftDb.UchetSet.Add(supply);
                    Program.wftDb.SaveChanges();
                    ShowUchet();
                }
            }
            else MessageBox.Show("Данные не выбраны!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowUchet()
        {
            listViewUchet.Items.Clear();
            foreach (UchetSet uchet in Program.wftDb.UchetSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                   uchet.IdBibl.ToString(),
                   uchet.BiblSet.LastName+" "+uchet.BiblSet.FirstName+" "+uchet.BiblSet.MiddleName,
                   uchet.IdChit.ToString(),
                   uchet.ChitSet.LastName+" "+uchet.ChitSet.FirstName+" "+uchet.ChitSet.MiddleName,
                   uchet.IdBook.ToString(),
                   uchet.BookSet.Name+" "+uchet.BookSet.Genre+" "+uchet.BookSet.Author
                }); ;
                item.Tag = uchet;
                listViewUchet.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewUchet.SelectedItems.Count == 1)
            {
                UchetSet uchet = listViewUchet.SelectedItems[0].Tag as UchetSet;
                uchet.IdBibl = Convert.ToInt32(comboBoxBibl.SelectedItem.ToString().Split('.')[0]);
                uchet.IdChit = Convert.ToInt32(comboBoxChit.SelectedItem.ToString().Split('.')[0]);
                uchet.IdBook = Convert.ToInt32(comboBoxBook.SelectedItem.ToString().Split('.')[0]);
                Program.wftDb.SaveChanges();
                ShowUchet();
            }
        }

        private void listViewUchet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUchet.SelectedItems.Count == 1)
            {
                UchetSet uchet = listViewUchet.SelectedItems[0].Tag as UchetSet;
                comboBoxBibl.SelectedIndex = comboBoxBibl.FindString(uchet.IdBibl.ToString());
                comboBoxChit.SelectedIndex = comboBoxChit.FindString(uchet.IdChit.ToString());
                comboBoxBook.SelectedIndex = comboBoxBook.FindString(uchet.IdBook.ToString());
            }
            else
            {
                comboBoxBibl.SelectedItem = null;
                comboBoxChit.SelectedItem = null;
                comboBoxBook.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewUchet.SelectedItems.Count == 1)
                {
                    UchetSet uchet = listViewUchet.SelectedItems[0].Tag as UchetSet;
                    Program.wftDb.UchetSet.Remove(uchet);
                    Program.wftDb.SaveChanges();
                    ShowUchet();
                }
                comboBoxBibl.SelectedItem = null;
                comboBoxChit.SelectedItem = null;
                comboBoxBook = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }  
}

