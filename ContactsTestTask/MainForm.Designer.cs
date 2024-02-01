namespace ContactsTestTask
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            getContactBtn = new Button();
            contactsDataGreedView = new DataGridView();
            ContactID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            DateofBirth = new DataGridViewTextBoxColumn();
            addContactBtn = new Button();
            removeContactBtn = new Button();
            editContactBtn = new Button();
            nameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            nameLabel = new Label();
            numberLabel = new Label();
            birthdayLabel = new Label();
            birthdayDatePicker = new DateTimePicker();
            saveBtn = new Button();
            cancelBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)contactsDataGreedView).BeginInit();
            SuspendLayout();
            // 
            // getContactBtn
            // 
            getContactBtn.Location = new Point(12, 12);
            getContactBtn.Name = "getContactBtn";
            getContactBtn.Size = new Size(120, 50);
            getContactBtn.TabIndex = 0;
            getContactBtn.Text = "Get Contacts";
            getContactBtn.UseVisualStyleBackColor = true;
            getContactBtn.Click += getContacts_Click;
            // 
            // contactsDataGreedView
            // 
            contactsDataGreedView.AllowUserToAddRows = false;
            contactsDataGreedView.AllowUserToDeleteRows = false;
            contactsDataGreedView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contactsDataGreedView.Columns.AddRange(new DataGridViewColumn[] { ContactID, FullName, PhoneNumber, DateofBirth });
            contactsDataGreedView.Location = new Point(12, 68);
            contactsDataGreedView.Name = "contactsDataGreedView";
            contactsDataGreedView.ReadOnly = true;
            contactsDataGreedView.RowHeadersVisible = false;
            contactsDataGreedView.RowHeadersWidth = 51;
            contactsDataGreedView.Size = new Size(512, 636);
            contactsDataGreedView.TabIndex = 1;
            // 
            // ContactID
            // 
            ContactID.DataPropertyName = "ContactID";
            ContactID.HeaderText = "Contact Id";
            ContactID.MinimumWidth = 6;
            ContactID.Name = "ContactID";
            ContactID.ReadOnly = true;
            ContactID.Width = 125;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 125;
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "Contact Number";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.ReadOnly = true;
            PhoneNumber.Resizable = DataGridViewTriState.False;
            PhoneNumber.Width = 125;
            // 
            // DateofBirth
            // 
            DateofBirth.DataPropertyName = "DateofBirth";
            DateofBirth.HeaderText = "Birth Date";
            DateofBirth.MinimumWidth = 6;
            DateofBirth.Name = "DateofBirth";
            DateofBirth.ReadOnly = true;
            DateofBirth.Resizable = DataGridViewTriState.False;
            DateofBirth.Width = 125;
            // 
            // addContactBtn
            // 
            addContactBtn.Location = new Point(138, 12);
            addContactBtn.Name = "addContactBtn";
            addContactBtn.Size = new Size(120, 50);
            addContactBtn.TabIndex = 2;
            addContactBtn.Text = "Add Contact";
            addContactBtn.UseVisualStyleBackColor = true;
            addContactBtn.Click += addContactBtn_Click;
            // 
            // removeContactBtn
            // 
            removeContactBtn.Location = new Point(404, 12);
            removeContactBtn.Name = "removeContactBtn";
            removeContactBtn.Size = new Size(120, 50);
            removeContactBtn.TabIndex = 3;
            removeContactBtn.Text = "Remove Contact";
            removeContactBtn.UseVisualStyleBackColor = true;
            removeContactBtn.Click += removeContactBtn_Click;
            // 
            // editContactBtn
            // 
            editContactBtn.Location = new Point(278, 12);
            editContactBtn.Name = "editContactBtn";
            editContactBtn.Size = new Size(120, 50);
            editContactBtn.TabIndex = 4;
            editContactBtn.Text = "Edit Contact";
            editContactBtn.UseVisualStyleBackColor = true;
            editContactBtn.Click += editContactBtn_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(617, 68);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(162, 27);
            nameTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(617, 115);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(162, 27);
            phoneTextBox.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameLabel.Location = new Point(540, 67);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(63, 25);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberLabel.Location = new Point(540, 117);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new Size(81, 25);
            numberLabel.TabIndex = 9;
            numberLabel.Text = "Number:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            birthdayLabel.Location = new Point(540, 163);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(81, 25);
            birthdayLabel.TabIndex = 10;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayDatePicker
            // 
            birthdayDatePicker.Location = new Point(617, 162);
            birthdayDatePicker.Name = "birthdayDatePicker";
            birthdayDatePicker.Size = new Size(162, 27);
            birthdayDatePicker.TabIndex = 11;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(585, 212);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(94, 29);
            saveBtn.TabIndex = 12;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(685, 212);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 13;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 753);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(birthdayDatePicker);
            Controls.Add(birthdayLabel);
            Controls.Add(numberLabel);
            Controls.Add(nameLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(editContactBtn);
            Controls.Add(removeContactBtn);
            Controls.Add(addContactBtn);
            Controls.Add(contactsDataGreedView);
            Controls.Add(getContactBtn);
            MaximumSize = new Size(815, 800);
            MinimumSize = new Size(550, 800);
            Name = "MainForm";
            Text = "Contacts Application";
            ((System.ComponentModel.ISupportInitialize)contactsDataGreedView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button getContactBtn;
        private DataGridView contactsDataGreedView;
        private DataGridViewTextBoxColumn ContactID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn DateofBirth;
        private Button addContactBtn;
        private Button removeContactBtn;
        private Button editContactBtn;
        private TextBox nameTextBox;
        private TextBox phoneTextBox;
        private Label nameLabel;
        private Label numberLabel;
        private Label birthdayLabel;
        private DateTimePicker birthdayDatePicker;
        private Button saveBtn;
        private Button cancelBtn;
    }
}
