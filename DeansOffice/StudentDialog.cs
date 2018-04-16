using DeansOffice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeansOffice
{
    public partial class StudentDialog : Form
    {
        private readonly MainForm MainForm;

        public StudentDialog(MainForm mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            LoadDepartmentComboBox();
        }

        private void LoadDepartmentComboBox()
        {
            DepartmentComboBox.Items.Add("Computer Science");
            DepartmentComboBox.Items.Add("Information Technology");
            DepartmentComboBox.Items.Add("Graphics");
            DepartmentComboBox.Items.Add("Interior Design");
            DepartmentComboBox.Items.Add("New Media Arts");
            DepartmentComboBox.Items.Add("Information Management");
            DepartmentComboBox.Items.Add("Culture Of Japan");

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(FirstNameTextBox.Text)) && !(string.IsNullOrWhiteSpace(LastNameTextBox.Text)) &&
                !(string.IsNullOrWhiteSpace(EmailTextBox.Text)) && !(string.IsNullOrWhiteSpace(TelephoneTextBox.Text)) &&
                !(string.IsNullOrWhiteSpace(PeselTextBox.Text)) && !(string.IsNullOrWhiteSpace(PassportNumberTextBox.Text)) &&
                !(string.IsNullOrWhiteSpace(CitizenshipTextBox.Text)) && !(string.IsNullOrWhiteSpace(CityTextBox.Text)) &&
                !(string.IsNullOrWhiteSpace(DepartmentComboBox.Text)) && !(string.IsNullOrWhiteSpace(IndexNumberTextBox.Text)))
            {
                MainForm.AddStudent(FirstNameTextBox.Text, LastNameTextBox.Text, EmailTextBox.Text, Convert.ToInt32(TelephoneTextBox.Text),
                    PassportNumberTextBox.Text, CitizenshipTextBox.Text, CityTextBox.Text, BirthdayDateTimePicker.Value.Year, DepartmentComboBox.Text,
                    Convert.ToInt32(IndexNumberTextBox.Text), Convert.ToInt32(DateTime.Now.Year.ToString()), "no photo");
                this.Close();
            }
        }
    }
}
