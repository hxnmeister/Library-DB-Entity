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
            this.ConfirmAuthorButton = new System.Windows.Forms.Button();
            this.AuthorInfoTextBox = new System.Windows.Forms.TextBox();
            this.AuthorComboBox = new System.Windows.Forms.ComboBox();
            this.AddAuthorButton = new System.Windows.Forms.Button();
            this.AuthorsDataGridView = new System.Windows.Forms.DataGridView();
            this.BookTabPage = new System.Windows.Forms.TabPage();
            this.PublisherTabPage = new System.Windows.Forms.TabPage();
            this.DeleteAuthorButton = new System.Windows.Forms.Button();
            this.EditAuthorButton = new System.Windows.Forms.Button();
            this.LibraryTabControl.SuspendLayout();
            this.AuthorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGridView)).BeginInit();
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
            this.LibraryTabControl.Size = new System.Drawing.Size(776, 426);
            this.LibraryTabControl.TabIndex = 0;
            this.LibraryTabControl.SelectedIndexChanged += new System.EventHandler(this.LibraryTabControl_SelectedIndexChanged);
            // 
            // AuthorTabPage
            // 
            this.AuthorTabPage.Controls.Add(this.EditAuthorButton);
            this.AuthorTabPage.Controls.Add(this.DeleteAuthorButton);
            this.AuthorTabPage.Controls.Add(this.ConfirmAuthorButton);
            this.AuthorTabPage.Controls.Add(this.AuthorInfoTextBox);
            this.AuthorTabPage.Controls.Add(this.AuthorComboBox);
            this.AuthorTabPage.Controls.Add(this.AddAuthorButton);
            this.AuthorTabPage.Controls.Add(this.AuthorsDataGridView);
            this.AuthorTabPage.Location = new System.Drawing.Point(4, 22);
            this.AuthorTabPage.Name = "AuthorTabPage";
            this.AuthorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AuthorTabPage.Size = new System.Drawing.Size(768, 400);
            this.AuthorTabPage.TabIndex = 0;
            this.AuthorTabPage.Text = "Authors";
            this.AuthorTabPage.UseVisualStyleBackColor = true;
            // 
            // ConfirmAuthorButton
            // 
            this.ConfirmAuthorButton.Enabled = false;
            this.ConfirmAuthorButton.Location = new System.Drawing.Point(634, 349);
            this.ConfirmAuthorButton.Name = "ConfirmAuthorButton";
            this.ConfirmAuthorButton.Size = new System.Drawing.Size(61, 45);
            this.ConfirmAuthorButton.TabIndex = 4;
            this.ConfirmAuthorButton.Text = "Confirm Entry";
            this.ConfirmAuthorButton.UseVisualStyleBackColor = true;
            this.ConfirmAuthorButton.Click += new System.EventHandler(this.ConfirmAuthorButton_Click);
            // 
            // AuthorInfoTextBox
            // 
            this.AuthorInfoTextBox.Enabled = false;
            this.AuthorInfoTextBox.Location = new System.Drawing.Point(662, 285);
            this.AuthorInfoTextBox.Name = "AuthorInfoTextBox";
            this.AuthorInfoTextBox.Size = new System.Drawing.Size(100, 20);
            this.AuthorInfoTextBox.TabIndex = 3;
            this.AuthorInfoTextBox.Enter += new System.EventHandler(this.AuthorInfoTextBox_Enter);
            // 
            // AuthorComboBox
            // 
            this.AuthorComboBox.FormattingEnabled = true;
            this.AuthorComboBox.Items.AddRange(new object[] {
            "Id",
            "FirstName",
            "LastName"});
            this.AuthorComboBox.Location = new System.Drawing.Point(634, 258);
            this.AuthorComboBox.Name = "AuthorComboBox";
            this.AuthorComboBox.Size = new System.Drawing.Size(128, 21);
            this.AuthorComboBox.TabIndex = 2;
            this.AuthorComboBox.SelectedIndexChanged += new System.EventHandler(this.AuthorComboBox_SelectedIndexChanged);
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.Enabled = false;
            this.AddAuthorButton.Location = new System.Drawing.Point(701, 349);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(61, 45);
            this.AddAuthorButton.TabIndex = 1;
            this.AddAuthorButton.Text = "Add Value";
            this.AddAuthorButton.UseVisualStyleBackColor = true;
            this.AddAuthorButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
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
            this.BookTabPage.Location = new System.Drawing.Point(4, 22);
            this.BookTabPage.Name = "BookTabPage";
            this.BookTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.BookTabPage.Size = new System.Drawing.Size(768, 400);
            this.BookTabPage.TabIndex = 1;
            this.BookTabPage.Text = "Books";
            this.BookTabPage.UseVisualStyleBackColor = true;
            // 
            // PublisherTabPage
            // 
            this.PublisherTabPage.Location = new System.Drawing.Point(4, 22);
            this.PublisherTabPage.Name = "PublisherTabPage";
            this.PublisherTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PublisherTabPage.Size = new System.Drawing.Size(768, 400);
            this.PublisherTabPage.TabIndex = 2;
            this.PublisherTabPage.Text = "Publishers";
            this.PublisherTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteAuthorButton
            // 
            this.DeleteAuthorButton.Location = new System.Drawing.Point(102, 258);
            this.DeleteAuthorButton.Name = "DeleteAuthorButton";
            this.DeleteAuthorButton.Size = new System.Drawing.Size(90, 45);
            this.DeleteAuthorButton.TabIndex = 5;
            this.DeleteAuthorButton.Text = "Delete Selected Value";
            this.DeleteAuthorButton.UseVisualStyleBackColor = true;
            this.DeleteAuthorButton.Click += new System.EventHandler(this.DeleteAuthorButton_Click);
            // 
            // EditAuthorButton
            // 
            this.EditAuthorButton.Location = new System.Drawing.Point(6, 258);
            this.EditAuthorButton.Name = "EditAuthorButton";
            this.EditAuthorButton.Size = new System.Drawing.Size(90, 45);
            this.EditAuthorButton.TabIndex = 6;
            this.EditAuthorButton.Text = "Confirm Editing  Value";
            this.EditAuthorButton.UseVisualStyleBackColor = true;
            this.EditAuthorButton.Click += new System.EventHandler(this.EditAuthorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LibraryTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LibraryTabControl.ResumeLayout(false);
            this.AuthorTabPage.ResumeLayout(false);
            this.AuthorTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LibraryTabControl;
        private System.Windows.Forms.TabPage AuthorTabPage;
        private System.Windows.Forms.TabPage BookTabPage;
        private System.Windows.Forms.TabPage PublisherTabPage;
        private System.Windows.Forms.DataGridView AuthorsDataGridView;
        private System.Windows.Forms.Button ConfirmAuthorButton;
        private System.Windows.Forms.TextBox AuthorInfoTextBox;
        private System.Windows.Forms.ComboBox AuthorComboBox;
        private System.Windows.Forms.Button AddAuthorButton;
        private System.Windows.Forms.Button EditAuthorButton;
        private System.Windows.Forms.Button DeleteAuthorButton;
    }
}

