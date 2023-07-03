namespace Домашнє_завдання
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
            this.LibraryTabControl = new System.Windows.Forms.TabControl();
            this.AuthorTabPage = new System.Windows.Forms.TabPage();
            this.AuthorsDataGridView = new System.Windows.Forms.DataGridView();
            this.BookTabPage = new System.Windows.Forms.TabPage();
            this.BooksDataGridView = new System.Windows.Forms.DataGridView();
            this.PublisherTabPage = new System.Windows.Forms.TabPage();
            this.PublishersDataGridView = new System.Windows.Forms.DataGridView();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.ParametrsComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.LibraryTabControl.SuspendLayout();
            this.AuthorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGridView)).BeginInit();
            this.BookTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).BeginInit();
            this.PublisherTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PublishersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LibraryTabControl
            // 
            this.LibraryTabControl.Controls.Add(this.AuthorTabPage);
            this.LibraryTabControl.Controls.Add(this.BookTabPage);
            this.LibraryTabControl.Controls.Add(this.PublisherTabPage);
            this.LibraryTabControl.Location = new System.Drawing.Point(12, 12);
            this.LibraryTabControl.Name = "LibraryTabControl";
            this.LibraryTabControl.SelectedIndex = 0;
            this.LibraryTabControl.Size = new System.Drawing.Size(776, 283);
            this.LibraryTabControl.TabIndex = 0;
            this.LibraryTabControl.SelectedIndexChanged += new System.EventHandler(this.LibraryTabControl_SelectedIndexChanged);
            // 
            // AuthorTabPage
            // 
            this.AuthorTabPage.Controls.Add(this.AuthorsDataGridView);
            this.AuthorTabPage.Location = new System.Drawing.Point(4, 22);
            this.AuthorTabPage.Name = "AuthorTabPage";
            this.AuthorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AuthorTabPage.Size = new System.Drawing.Size(768, 257);
            this.AuthorTabPage.TabIndex = 0;
            this.AuthorTabPage.Text = "Authors";
            this.AuthorTabPage.UseVisualStyleBackColor = true;
            // 
            // AuthorsDataGridView
            // 
            this.AuthorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.AuthorsDataGridView.MultiSelect = false;
            this.AuthorsDataGridView.Name = "AuthorsDataGridView";
            this.AuthorsDataGridView.Size = new System.Drawing.Size(756, 246);
            this.AuthorsDataGridView.TabIndex = 0;
            // 
            // BookTabPage
            // 
            this.BookTabPage.Controls.Add(this.BooksDataGridView);
            this.BookTabPage.Location = new System.Drawing.Point(4, 22);
            this.BookTabPage.Name = "BookTabPage";
            this.BookTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BookTabPage.Size = new System.Drawing.Size(768, 257);
            this.BookTabPage.TabIndex = 1;
            this.BookTabPage.Text = "Books";
            this.BookTabPage.UseVisualStyleBackColor = true;
            // 
            // BooksDataGridView
            // 
            this.BooksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDataGridView.Location = new System.Drawing.Point(6, 6);
            this.BooksDataGridView.MultiSelect = false;
            this.BooksDataGridView.Name = "BooksDataGridView";
            this.BooksDataGridView.Size = new System.Drawing.Size(756, 246);
            this.BooksDataGridView.TabIndex = 7;
            // 
            // PublisherTabPage
            // 
            this.PublisherTabPage.Controls.Add(this.PublishersDataGridView);
            this.PublisherTabPage.Location = new System.Drawing.Point(4, 22);
            this.PublisherTabPage.Name = "PublisherTabPage";
            this.PublisherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PublisherTabPage.Size = new System.Drawing.Size(768, 257);
            this.PublisherTabPage.TabIndex = 2;
            this.PublisherTabPage.Text = "Publishers";
            this.PublisherTabPage.UseVisualStyleBackColor = true;
            // 
            // PublishersDataGridView
            // 
            this.PublishersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PublishersDataGridView.Location = new System.Drawing.Point(6, 6);
            this.PublishersDataGridView.MultiSelect = false;
            this.PublishersDataGridView.Name = "PublishersDataGridView";
            this.PublishersDataGridView.Size = new System.Drawing.Size(756, 246);
            this.PublishersDataGridView.TabIndex = 7;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(22, 352);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(90, 45);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Confirm Editing  Value";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(22, 301);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(90, 45);
            this.DeleteButton.TabIndex = 11;
            this.DeleteButton.Text = "Delete Selected Value";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Enabled = false;
            this.ConfirmButton.Location = new System.Drawing.Point(650, 392);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(61, 45);
            this.ConfirmButton.TabIndex = 10;
            this.ConfirmButton.Text = "Confirm Entry";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Enabled = false;
            this.InfoTextBox.Location = new System.Drawing.Point(678, 328);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(100, 20);
            this.InfoTextBox.TabIndex = 9;
            this.InfoTextBox.Enter += new System.EventHandler(this.InfoTextBox_Enter);
            // 
            // ParametrsComboBox
            // 
            this.ParametrsComboBox.FormattingEnabled = true;
            this.ParametrsComboBox.Items.AddRange(new object[] {
            "Id",
            "FirstName",
            "LastName"});
            this.ParametrsComboBox.Location = new System.Drawing.Point(650, 301);
            this.ParametrsComboBox.Name = "ParametrsComboBox";
            this.ParametrsComboBox.Size = new System.Drawing.Size(128, 21);
            this.ParametrsComboBox.TabIndex = 8;
            this.ParametrsComboBox.SelectedIndexChanged += new System.EventHandler(this.ParametrsComboBox_SelectedIndexChanged_1);
            // 
            // AddButton
            // 
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(717, 392);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(61, 45);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add Value";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.ParametrsComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LibraryTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LibraryTabControl.ResumeLayout(false);
            this.AuthorTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGridView)).EndInit();
            this.BookTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksDataGridView)).EndInit();
            this.PublisherTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PublishersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl LibraryTabControl;
        private System.Windows.Forms.TabPage AuthorTabPage;
        private System.Windows.Forms.TabPage BookTabPage;
        private System.Windows.Forms.TabPage PublisherTabPage;
        private System.Windows.Forms.DataGridView AuthorsDataGridView;
        private System.Windows.Forms.DataGridView BooksDataGridView;
        private System.Windows.Forms.DataGridView PublishersDataGridView;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.ComboBox ParametrsComboBox;
        private System.Windows.Forms.Button AddButton;
    }
}

