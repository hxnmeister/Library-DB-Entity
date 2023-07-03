using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
            if(AddButton.Enabled) AddButton.Enabled = false;
            ParametrsComboBox.Items.Clear();

            switch (LibraryTabControl.SelectedIndex)
            {
                case 0:
                    AuthorsDataGridView.DataSource = myLibrary.Author.ToList();
                    ParametrsComboBox.Items.AddRange(new string[] { "Id", "FirstName", "LastName"});
                    author = new Author();
                    break;
                case 1:
                    BooksDataGridView.DataSource = myLibrary.Book.ToList();
                    ParametrsComboBox.Items.AddRange(new string[] { "Id", "Title", "IdAuthor", "Pages", "Price", "IdPublisher"});
                    book = new Book();
                    break;
                case 2:
                    PublishersDataGridView.DataSource = myLibrary.Publisher.ToList();
                    ParametrsComboBox.Items.AddRange(new string[] { "Id", "PublisherName", "Address"});
                    publisher = new Publisher();
                    break;
            }
        }

        private void InfoTextBox_Enter(object sender, EventArgs e)
        {
            InfoTextBox.Clear();
        }

        private void ParametrsComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!InfoTextBox.Enabled) InfoTextBox.Enabled = true;
            if (!ConfirmButton.Enabled) ConfirmButton.Enabled = true;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (LibraryTabControl.SelectedIndex)
                {
                    case 0:
                        myLibrary.Author.Remove(AuthorsDataGridView.SelectedRows[0].DataBoundItem as Author);
                        break;
                    case 1:

                        break;
                    case 2:

                        break;
                }

                myLibrary.SaveChanges();
                MessageBox.Show("Для того щоб побачити зміни оновіть вкладку!");
            }
            catch (Exception)
            {
                MessageBox.Show("Для того щоб видалити запис, виберіть його повністю!");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            switch (LibraryTabControl.SelectedIndex)
            {
                case 0:
                    myLibrary.Author.AddOrUpdate(AuthorsDataGridView.Rows[AuthorsDataGridView.SelectedCells[0].RowIndex].DataBoundItem as Author);
                    break;
                case 1:

                    break;
                case 2:

                    break;
            }

            myLibrary.SaveChanges();
            MessageBox.Show("Для того щоб побачити зміни оновіть вкладку!");
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            switch (LibraryTabControl.SelectedIndex)
            {
                case 0:
                    switch (ParametrsComboBox.SelectedIndex)
                    {
                        case 0:
                            if (CheckNumber(InfoTextBox.Text, out int number) && !myLibrary.Author.ToList().Any(x => x.Id == number))
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
                            author.FirstName = InfoTextBox.Text;
                            SuccsessMessage(InfoTextBox.Text);
                            break;
                        case 2:
                            author.LastName = InfoTextBox.Text;
                            SuccsessMessage(InfoTextBox.Text);
                            break;
                    }

                    InfoTextBox.Focus();
                    if (author.Id != 0 && author.LastName != null && author.FirstName != null) AddButton.Enabled = true;

                    break;
                case 1:

                    break;
                case 2:

                    break;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            switch (LibraryTabControl.SelectedIndex)
            {
                case 0:
                    myLibrary.Author.Add(author);
                    myLibrary.SaveChanges();

                    MessageBox.Show("Нового автора було додано, оновіть вкладку щоб побачити зміни!");

                    author = new Author();
                    break;
                case 1:

                    break;

                case 2:

                    break;
            }

            InfoTextBox.Enabled = false;
            ConfirmButton.Enabled = false;
            ParametrsComboBox.SelectedIndex = -1;
            AddButton.Enabled = false;
        }
    }
}
