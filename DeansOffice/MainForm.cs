using DeansOffice.DAL;
using DeansOffice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeansOffice
{
    public partial class MainForm : Form
    {

        public IDeansOfficeDb db;

        public MainForm(IDeansOfficeDb db)
        {
            InitializeComponent();
            LoadSemesterComboBox();
            this.db = db;
            StudentsDataGridView.DataSource = db.GetStudents("select * from Student");
        }

        public void LoadSemesterComboBox()
        {
            SemesterComboBox.Items.Add("All");
            SemesterComboBox.Items.Add("1");
            SemesterComboBox.Items.Add("2");
            SemesterComboBox.Items.Add("3");
            SemesterComboBox.Items.Add("4");
            SemesterComboBox.Items.Add("5");
            SemesterComboBox.Items.Add("6");
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new StudentDialog(this);
            form.ShowDialog();
        }

        public void AddStudent(String Name, String Surname, String Email, int Phone, String PassportNumber, String Citizenship,
            String CityOfBirth, int YearOfBirth, String Faculty, int IndexNumber, int YearOfRegistration, String Photo)
        {
            this.db.AddStudent(Name, Surname, Email,Phone, PassportNumber, Citizenship,
            CityOfBirth, YearOfBirth, Faculty, IndexNumber, YearOfRegistration, Photo);
            StudentsDataGridView.DataSource = db.GetStudents("select * from Student");
            StudentsDataGridView.Update();
            StudentsDataGridView.Refresh();
        }

        private void EditStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void RemoveStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string SearchPhrase = searchPhraseTB.Text;
            if (LastNameCheckBox.Checked==true)
            {
                StudentsDataGridView.DataSource = db.GetStudents("select * from Student where Surname like '" + SearchPhrase + "%'");
                         }
            else if (StudentNumberCheckBox.Checked == true && int.TryParse(SearchPhrase, out int n))
            {
                StudentsDataGridView.DataSource = db.GetStudents("select * from Student where IndexNumber=" +SearchPhrase);
            }
            else
            {
                StudentsDataGridView.DataSource = db.GetStudents("select * from Student");

            }
            StudentsDataGridView.Update();
            StudentsDataGridView.Refresh();
        }

        private void SemesterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String semesterCB = SemesterComboBox.Text;
            if (semesterCB.Equals("All"))
            {
                StudentsDataGridView.DataSource = db.GetStudents("select * from Student");
            }
            else if (int.TryParse(semesterCB, out int n))
            {
                StudentsDataGridView.DataSource = db.GetStudents("select s.Name, s.Surname, s.Email, s.Phone, s.PassportNumber, s.Citizenship, s.CityOfBirth, s.YearOfBirth, s.Faculty, s.IndexNumber, s.YearOfRegistration, s.Photo" +
                    " from Student s left join Semester sem " +
                    "on s.IndexNumber=sem.StudentsIndexNumber " +
                    "where sem.SemesterNumber=" + semesterCB);
            }
            StudentsDataGridView.Update();
            StudentsDataGridView.Refresh();
        }

        private void dodajStudentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDialog studentDialog = new StudentDialog(this);
            studentDialog.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in StudentsDataGridView.SelectedCells)
            {
                if (cell.Selected && cell.RowIndex >= 0 )
                {
                    int RowIndex = StudentsDataGridView.CurrentCell.RowIndex;
                    this.db.RemoveStudent(StudentsDataGridView.Rows[RowIndex].Cells[9].Value.ToString());
                    break;
                }
            }
            StudentsDataGridView.DataSource = db.GetStudents("select * from Student");
            StudentsDataGridView.Update();
            StudentsDataGridView.Refresh();
        }

    }
}
