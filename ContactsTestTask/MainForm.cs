using ContactsTestTask.Repository;
using System.Data.SqlClient;
using ContactsTestTask.Models;
using System.Diagnostics.Contracts;

namespace ContactsTestTask
{
    public partial class MainForm : Form
    {
        private readonly IRepository _repository;
        private Contact _contact = new Contact();
        private bool _isUpdate = false;

        public MainForm()
        {
            InitializeComponent();
            _repository = new ContactsTestTask.Repository.Repository("Data Source=Ivan\\MSSQLSERVER01;" +
                                                                      "Initial Catalog=ContactsDB;" +
                                                                      "Integrated Security=SSPI;");
            LoadContacts();
            SetBasicSize();
        }
        private void SetBasicSize()
        {
            nameTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            birthdayDatePicker.Value = DateTime.Today;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Size = new Size(550, 800);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void SetEditSize()
        {
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Size = new Size(815, 800);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private async Task LoadContacts()
        {
            var data = await _repository.GetContacts();
            contactsDataGreedView.DataSource = data;
        }

        private async void getContacts_Click(object sender, EventArgs e)
        {
            await LoadContacts();
        }

        private void addContactBtn_Click(object sender, EventArgs e)
        {
            _isUpdate = false;
            SetEditSize();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            SetBasicSize();
        }

        private void editContactBtn_Click(object sender, EventArgs e)
        {
            if (contactsDataGreedView.SelectedCells.Count == 0)
                MessageBox.Show("Please select the contact you want to edit");
            else
            {
                var rowIndex = contactsDataGreedView.SelectedCells[0].RowIndex;

                _contact.Id = (int)contactsDataGreedView.Rows[rowIndex].Cells["ContactID"].Value;
                _contact.Name = contactsDataGreedView.Rows[rowIndex].Cells["FullName"].Value.ToString();
                _contact.PhoneNumber = contactsDataGreedView.Rows[rowIndex].Cells["PhoneNumber"].Value.ToString();
                _contact.BirthDay = Convert.ToDateTime(contactsDataGreedView.Rows[rowIndex].Cells["DateofBirth"].Value);

                nameTextBox.Text = _contact.Name;
                phoneTextBox.Text = _contact.PhoneNumber;
                birthdayDatePicker.Value = _contact.BirthDay;

                _isUpdate = true;

                SetEditSize();
            }
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            int tmp;
            if (nameTextBox.Text.Length < 5)
            {
                MessageBox.Show("Enter correct name!");
            }
            else if (phoneTextBox.Text.Length < 8 || int.TryParse(phoneTextBox.Text, out tmp))
            {
                MessageBox.Show("Enter correct phone number!");
            }
            else
            {
                _contact.Name = nameTextBox.Text;
                _contact.PhoneNumber = phoneTextBox.Text;
                _contact.BirthDay = birthdayDatePicker.Value;

                if (_isUpdate)
                {
                    _repository.UpdateContact(_contact);
                    MessageBox.Show("Contact " + _contact.Name + " was successfully updated");
                }
                else
                {
                    _repository.InsertContact(_contact);
                    MessageBox.Show("Contact " + _contact.Name + " was successfully created");
                }

                await LoadContacts();
                SetBasicSize();
            }
        }

        private async void removeContactBtn_Click(object sender, EventArgs e)
        {
            var rowIndex = contactsDataGreedView.SelectedCells[0].RowIndex;

            var id = (int)contactsDataGreedView.Rows[rowIndex].Cells["ContactID"].Value;
            var tmpName = contactsDataGreedView.Rows[rowIndex].Cells["FullName"].Value.ToString();
            _repository.DeleteContact(id);
            MessageBox.Show("Contact " + tmpName + " was successfully deleved");

            await LoadContacts();
        }
    }
}
