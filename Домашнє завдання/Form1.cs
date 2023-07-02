using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Домашнє_завдання
{
    public partial class Form1 : Form
    {
        myLibraryEntities myLibrary = null;
        Author author = null;
        Book book = null;
        Publisher publisher = null;

        public Form1()
        {
            InitializeComponent();

            myLibrary = new myLibraryEntities();
            author = new Author();
            book = new Book();
            publisher = new Publisher();

            AuthorsDataGridView.DataSource = myLibrary.Author.ToList();
        }

        private bool CheckNumber(string value, out int result)
        {
            return Int32.TryParse(value, out result);
        }
        private void SuccsessMessage(string value)
        {
            MessageBox.Show($"Значення {value} було записано!");
        }
        
        private void LibraryTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(LibraryTabControl.SelectedIndex)
            { 
                case 0:
                    AuthorsDataGridView.DataSource = myLibrary.Author.ToList();
                    author = new Author();
                    break;
            }
        }
        private void AuthorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!AuthorInfoTextBox.Enabled) AuthorInfoTextBox.Enabled = true;
            if(!ConfirmAuthorButton.Enabled) ConfirmAuthorButton.Enabled = true;
        }

        private void ConfirmAuthorButton_Click(object sender, EventArgs e)
        {
            switch (AuthorComboBox.SelectedIndex)
            {
                case 0:
                    if (CheckNumber(AuthorInfoTextBox.Text, out int number) && !myLibrary.Author.ToList().Any(x => x.Id == number))
                    {
                        author.Id = number;
                        SuccsessMessage(number.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Введено не коректне значення Id!");
                    }
                    break;
                case 1:
                    author.FirstName = AuthorInfoTextBox.Text;
                    SuccsessMessage(AuthorInfoTextBox.Text);
                    break;
                case 2:
                    author.LastName = AuthorInfoTextBox.Text;
                    SuccsessMessage(AuthorInfoTextBox.Text);
                    break;
            }

            AuthorInfoTextBox.Focus();
            if (author.Id != 0 && author.LastName != null && author.FirstName != null) AddAuthorButton.Enabled = true;
        }

        private void AuthorInfoTextBox_Enter(object sender, EventArgs e)
        {
            AuthorInfoTextBox.Clear();
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            myLibrary.Author.Add(author);
            myLibrary.SaveChanges();

            AuthorInfoTextBox.Enabled = false;
            ConfirmAuthorButton.Enabled = false;
            AuthorComboBox.SelectedIndex = -1;
            AddAuthorButton.Enabled = false;

            MessageBox.Show("Нового автора було додано, оновіть вкладку щоб побачити зміни!");

            author = new Author();
        }

        private void DeleteAuthorButton_Click(object sender, EventArgs e)
        {
            myLibrary.Author.Remove(AuthorsDataGridView.SelectedRows[0].DataBoundItem as Author);

            myLibrary.SaveChanges();

            MessageBox.Show("Для того щоб побачити зміни оновіть вкладку!");
        }

        private void EditAuthorButton_Click(object sender, EventArgs e)
        {
            AuthorsDataGridView.CellValueChanged += AuthorsDataGridView_CellValueChanged;
        }

        private void AuthorsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
