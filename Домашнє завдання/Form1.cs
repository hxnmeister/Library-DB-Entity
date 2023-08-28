using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            if (AddButton.Enabled) AddButton.Enabled = false;
            if (ConfirmButton.Enabled) ConfirmButton.Enabled = false;
            if (ParametrsComboBox.SelectedIndex != -1) ParametrsComboBox.SelectedIndex = -1;
            ParametrsComboBox.Items.Clear();

            switch (LibraryTabControl.SelectedIndex)
            {
                case 0:
                    author = new Author();

                    AuthorsDataGridView.DataSource = myLibrary.Author.ToList();
                    ParametrsComboBox.Items.AddRange(new string[] { "Id", "FirstName", "LastName" });
                    break;
                case 1:
                    book = new Book();

                    BooksDataGridView.DataSource = myLibrary.Book.ToList();
                    ParametrsComboBox.Items.AddRange(new string[] { "Id", "Title", "IdAuthor", "Pages", "Price", "IdPublisher" });
                    break;
                case 2:
                    publisher = new Publisher();

                    PublishersDataGridView.DataSource = myLibrary.Publisher.ToList();
                    ParametrsComboBox.Items.AddRange(new string[] { "Id", "PublisherName", "Address" });
                    break;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (LibraryTabControl.SelectedIndex)
                {
                    case 0:
                        Author tempAuthor = AuthorsDataGridView.SelectedRows[0].DataBoundItem as Author;

                        if (tempAuthor != null)
                        {
                            bool hasBooks = myLibrary.Book.Any(b => b.IdAuthor == tempAuthor.Id);

                            if (hasBooks)
                            {
                                DialogResult result = MessageBox.Show("Даний автор має пов`язані записи в таблиці Books\nВидаляючи цього автора Ви видалете і книгу", "Підтверджуете видалення?", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    var associatedBooks = myLibrary.Book.Where(b => b.IdAuthor == tempAuthor.Id).ToList();
                                    foreach (var book in associatedBooks)
                                    {
                                        myLibrary.Book.Remove(book);
                                    }

                                    myLibrary.Author.Remove(tempAuthor);
                                }
                            }
                            else
                            {
                                myLibrary.Author.Remove(tempAuthor);
                            }

                        }
                        break;
                    case 1:
                        myLibrary.Book.Remove(BooksDataGridView.SelectedRows[0].DataBoundItem as Book);
                        break;
                    case 2:
                        Publisher tempPublisher = PublishersDataGridView.SelectedRows[0].DataBoundItem as Publisher;

                        if (tempPublisher != null)
                        {
                            bool hasBooks = myLibrary.Book.Any(b => b.IdPublisher == tempPublisher.Id);

                            if (hasBooks)
                            {
                                DialogResult result = MessageBox.Show("Даний видавець має пов`язані записи в таблиці Books\nВидаляючи цього видавця Ви видалете і книгу", "Підтверджуете видалення?", MessageBoxButtons.YesNo);
                                if (result == DialogResult.Yes)
                                {
                                    var associatedBooks = myLibrary.Book.Where(b => b.IdPublisher == tempPublisher.Id).ToList();
                                    foreach (var book in associatedBooks)
                                    {
                                        myLibrary.Book.Remove(book);
                                    }

                                    myLibrary.Publisher.Remove(tempPublisher);
                                }
                            }
                            else
                            {
                                myLibrary.Publisher.Remove(tempPublisher);
                            }
                        }
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
                    myLibrary.Book.AddOrUpdate(BooksDataGridView.Rows[BooksDataGridView.SelectedCells[0].RowIndex].DataBoundItem as Book);
                    break;
                case 2:
                    myLibrary.Publisher.AddOrUpdate(PublishersDataGridView.Rows[PublishersDataGridView.SelectedCells[0].RowIndex].DataBoundItem as Publisher);
                    break;
            }

            myLibrary.SaveChanges();
            MessageBox.Show("Для того щоб побачити зміни оновіть вкладку!");
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ParametrsComboBox.SelectedIndex;

            try
            {
                switch (LibraryTabControl.SelectedIndex)
                {
                    case 0:
                        switch (selectedIndex)
                        {
                            case 0:
                                if (CheckNumber(InfoTextBox.Text, out int number) && !myLibrary.Author.ToList().Any(x => x.Id == number))
                                {
                                    author.Id = number;
                                    SuccsessMessage(number.ToString());
                                }
                                else
                                {
                                    throw new Exception("Введено некоректний Id!");
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

                        if (author.Id != 0 && author.LastName != null && author.FirstName != null) AddButton.Enabled = true;

                        break;
                    case 1:
                        int checkedNumber = 0;

                        if (selectedIndex == 0 || (selectedIndex > 1 && selectedIndex < 6))
                        {
                            if (!CheckNumber(InfoTextBox.Text, out checkedNumber))
                            {
                                throw new Exception("Введено некорректне число значення!");
                            }
                        }

                        switch (selectedIndex)
                        {
                            case 0:
                                if (!myLibrary.Book.ToList().Any(x => x.Id == checkedNumber))
                                {
                                    book.Id = checkedNumber;
                                    SuccsessMessage(checkedNumber.ToString());
                                }
                                else
                                {
                                    throw new Exception("Введено некоректний Id!");
                                }
                                break;
                            case 1:
                                book.Title = InfoTextBox.Text;
                                SuccsessMessage(InfoTextBox.Text);
                                break;
                            case 2:
                                book.IdAuthor = checkedNumber;
                                SuccsessMessage(checkedNumber.ToString());
                                break;
                            case 3:
                                book.Pages = checkedNumber;
                                SuccsessMessage(checkedNumber.ToString());
                                break;
                            case 4:
                                book.Price = checkedNumber;
                                SuccsessMessage(checkedNumber.ToString());
                                break;
                            case 5:
                                book.IdPublisher = checkedNumber;
                                SuccsessMessage(checkedNumber.ToString());
                                break;
                        }

                        if (book.Id != 0 && book.Title != null && book.IdAuthor != 0 && book.Pages != 0 && book.Price != 0 && book.IdPublisher != 0) AddButton.Enabled = true;
                        break;
                    case 2:
                        switch (selectedIndex)
                        {
                            case 0:
                                if (CheckNumber(InfoTextBox.Text, out int number) && !myLibrary.Publisher.ToList().Any(x => x.Id == number))
                                {
                                    publisher.Id = number;
                                    SuccsessMessage(number.ToString());
                                }
                                else
                                {
                                    throw new Exception("Введено некоректний Id!");
                                }
                                break;
                            case 1:
                                publisher.PublisherName = InfoTextBox.Text;
                                SuccsessMessage(InfoTextBox.Text);
                                break;
                            case 2:
                                publisher.Address = InfoTextBox.Text;
                                SuccsessMessage(InfoTextBox.Text);
                                break;
                        }

                        if (publisher.Id != 0 && publisher.PublisherName != null && publisher.Address != null) AddButton.Enabled = true;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                InfoTextBox.Focus();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int tabControlIndex = LibraryTabControl.SelectedIndex;
            try
            {
                switch (tabControlIndex)
                {
                    case 0:
                        myLibrary.Author.Add(author);
                        myLibrary.SaveChanges();
                        

                        MessageBox.Show("Нового автора було додано, оновіть вкладку щоб побачити зміни!");
                        break;
                    case 1:
                        myLibrary.Book.Add(book);
                        myLibrary.SaveChanges();

                        MessageBox.Show("Нову книгу було додано, оновіть вкладку щоб побачити зміни!");
                        break;

                    case 2:
                        myLibrary.Publisher.Add(publisher);
                        myLibrary.SaveChanges();

                        MessageBox.Show("Нового видавця було додано, оновіть вкладку щоб побачити зміни!");
                        break;
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Перевірте правильність вводу Id!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                InfoTextBox.Enabled = false;
                ConfirmButton.Enabled = false;
                ParametrsComboBox.SelectedIndex = -1;
                AddButton.Enabled = false;

                if (tabControlIndex == 0) author = new Author();
                else if (tabControlIndex == 1) book = new Book();
                else if (tabControlIndex == 2) publisher = new Publisher();
            }
        }

        private void ParametrsComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!InfoTextBox.Enabled) InfoTextBox.Enabled = true;
            if (!ConfirmButton.Enabled) ConfirmButton.Enabled = true;
        }
        private void InfoTextBox_Enter(object sender, EventArgs e)
        {
            InfoTextBox.Clear();
        }
    }
}
