using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeansOffice.Models;

namespace DeansOffice.DAL
{
    public class SqlServerDeansOfficeDb : IDeansOfficeDb
    {
        public const string DbConnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PjatkAcademy;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public IEnumerable<Student> GetStudents(String SqlCommand)
        {
            var list = new List<Student>();
            using (var con = new SqlConnection(DbConnection))
            {
                var com = new SqlCommand();

                com.Connection = con;
                com.CommandText = SqlCommand;

                con.Open();
                using (var dr = com.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        var newSt = new Student();
                        newSt.Name = dr["Name"].ToString();
                        newSt.Surname = dr["Surname"].ToString();
                        newSt.Email = dr["Email"].ToString();
                        newSt.Phone = (int)dr["Phone"];
                        newSt.PassportNumber = dr["PassportNumber"].ToString();
                        newSt.Citizenship = dr["Citizenship"].ToString();
                        newSt.CityOfBirth = dr["CityOfBirth"].ToString();
                        newSt.YearOfBirth = (int)dr["YearOfBirth"];
                        newSt.Faculty = dr["Faculty"].ToString();
                        newSt.IndexNumber = (int)dr["IndexNumber"];
                        newSt.YearOfRegistration = (int)dr["YearOfRegistration"];
                        newSt.Photo = dr["Photo"].ToString();
                        list.Add(newSt);
                    }
                }
            }
            return list;
        }

        public void AddStudent(String Name, String Surname, String Email, int Phone, String PassportNumber, String Citizenship,
            String CityOfBirth, int YearOfBirth, String Faculty, int IndexNumber, int YearOfRegistration, String Photo)
        {
            using (var con = new SqlConnection(DbConnection))
            {
                string cmdString = "insert into Student (Name, Surname, Email, Phone, PassportNumber, Citizenship, " +
                    "CityOfBirth, YearOfBirth, Faculty, IndexNumber, YearOfRegistration, Photo)" +
                    "values ('" + Name + "','" + Surname + "','" + Email + "'," + Phone + ",'" + PassportNumber + "','" + Citizenship + "','" +
                    CityOfBirth + "'," + YearOfBirth + ",'" + Faculty + "'," + IndexNumber + "," + YearOfRegistration + ",'" + Photo + "')";
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = con;
                    comm.CommandText = cmdString;
                    try
                    {
                        con.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Failed to add new student.");
                    }
                }
                MessageBox.Show("New student was added successfully");
            }
        }

        public void RemoveStudent(String Index)
        {
            using (var con = new SqlConnection(DbConnection))
            {
                string cmdString = "delete from Student " +
                    "where IndexNumber=" + Index;
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = con;
                    comm.CommandText = cmdString;
                    try
                    {
                        con.Open();
                        comm.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Failed to remove student.");
                    }
                }
                MessageBox.Show("Student was removed successfully");
            }
        }
    }
}




