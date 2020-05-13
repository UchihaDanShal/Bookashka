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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
            ShowBook();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            BookSet bookSet = new BookSet();

            bookSet.Name = textBoxName.Text;
            bookSet.Genre = textBoxGenre.Text;
            bookSet.Author = textBoxAuthor.Text;
           

            Program.wftDb.BookSet.Add(bookSet);

            Program.wftDb.SaveChanges();
            ShowBook();
        }
        void ShowBook()
        {
            listViewBook.Items.Clear();

            foreach (BookSet bookSet in Program.wftDb.BookSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    bookSet.Id.ToString(), bookSet.Name, bookSet.Genre, bookSet.Author, 
                });
                item.Tag = bookSet;

                listViewBook.Items.Add(item);
            }
            listViewBook.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewBook.SelectedItems.Count == 1)
            {
                BookSet bookSet = listViewBook.SelectedItems[0].Tag as BookSet;
                bookSet.Name = textBoxName.Text;
                bookSet.Genre = textBoxGenre.Text;
                bookSet.Author = textBoxAuthor.Text;                
                Program.wftDb.SaveChanges();
                ShowBook();
            }
        }

        private void listViewBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBook.SelectedItems.Count == 1)
            {
                BookSet bookSet = listViewBook.SelectedItems[0].Tag as BookSet;
                bookSet.Name = textBoxName.Text;
                bookSet.Genre = textBoxGenre.Text;
                bookSet.Author = textBoxAuthor.Text;
            }
            else
            {
                textBoxName.Text = "";
                textBoxGenre.Text = "";
                textBoxAuthor.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBook.SelectedItems.Count == 1)
                {
                    BookSet bookSet = listViewBook.SelectedItems[0].Tag as BookSet;
                    Program.wftDb.BookSet.Remove(bookSet);
                    Program.wftDb.SaveChanges();
                    ShowBook();
                }
                textBoxName.Text = "";
                textBoxGenre.Text = "";
                textBoxAuthor.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
