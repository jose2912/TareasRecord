using StudentRecordManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRecordManagementSystem.Models
{
    public class PersonalDataAccessLayer
    {
        
      string connectionString = ConnectionString.CName;
      

        public IEnumerable<Personal> GetAllPersonal()
        {
            List<Personal> lstStudent = new List<Personal>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //SqlCommand cmd = new SqlCommand("spGetAllPersonal", con);
                SqlCommand cmd = new SqlCommand("spGetAllPersonal", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Personal student = new Personal();

                    student.Id = Convert.ToInt32(rdr["IdPersonal"]);
                    student.TipoDoc = rdr["TipoDoc"].ToString();
                    student.NumeroDoc = rdr["NumeroDoc"].ToString();
                    student.ApPaterno = rdr["ApPaterno"].ToString();
                    student.ApMaterno = rdr["ApMaterno"].ToString();
                    student.Nombre1 = rdr["Nombre1"].ToString();
                    student.Nombre2 = rdr["Nombre2"].ToString();
                    student.NombreCompleto = rdr["NombreCompleto"].ToString();
                    student.FechaNac = DateTime.Parse(rdr["FechaNac"].ToString());
                    student.FechaIngreso = DateTime.Parse(rdr["FechaIngreso"].ToString());

                    lstStudent.Add(student);
                }
                con.Close();
            }
            return lstStudent;
        }

        //ListarClientes
        public void AddPersonal(Personal student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddPersonal", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@TipoDoc", student.FirstName);
                cmd.Parameters.AddWithValue("@NumeroDoc", student.NumeroDoc);
                cmd.Parameters.AddWithValue("@ApPaterno", student.ApPaterno);
                cmd.Parameters.AddWithValue("@ApMaterno", student.ApMaterno);
                cmd.Parameters.AddWithValue("@Nombre1", student.Nombre1);
                cmd.Parameters.AddWithValue("@Nombre2", student.Nombre2);
                cmd.Parameters.AddWithValue("@NombreCompleto", student.Nombre1 + ", " + student.Nombre2);
                cmd.Parameters.AddWithValue("@FechaNac", student.FechaNac);
                cmd.Parameters.AddWithValue("@FechaIngreso", DateTime.Now);
                cmd.Parameters.AddWithValue("@Estado",1);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        //public void AddStudent(Student student)
        //{
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        SqlCommand cmd = new SqlCommand("spAddStudent", con);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
        //        cmd.Parameters.AddWithValue("@LastName", student.LastName);
        //        cmd.Parameters.AddWithValue("@Email", student.Email);
        //        cmd.Parameters.AddWithValue("@Mobile", student.Mobile);
        //        cmd.Parameters.AddWithValue("@Address", student.Address);

        //        con.Open();
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //    }
        //}
        public void UpdateStudent(Personal student)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", student.Id);
                cmd.Parameters.AddWithValue("@TipoDOc", student.TipoDoc);
                cmd.Parameters.AddWithValue("@ApPaterno", student.ApPaterno);
                cmd.Parameters.AddWithValue("@ApMaterno", student.ApMaterno);
                cmd.Parameters.AddWithValue("@Nombre1", student.Nombre1);
                cmd.Parameters.AddWithValue("@Nombre2", student.Nombre2);
                cmd.Parameters.AddWithValue("@FechaNac", student.FechaNac);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Personal GetPersonalData(int? id)
        {
            Personal personal = new Personal();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Personal WHERE IdPersonal= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    personal.Id = Convert.ToInt32(rdr["IdPersonal"]);
                    personal.TipoDoc = rdr["LastName"].ToString();
                    personal.NumeroDoc = rdr["NumeroDoc"].ToString();
                    personal.ApPaterno = rdr["ApPaterno"].ToString();
                    personal.ApMaterno = rdr["ApMaterno"].ToString();
                    personal.Nombre1 = rdr["Nombre1"].ToString();
                    personal.Nombre2 = rdr["Nombre2"].ToString();
                    personal.FechaIngreso = DateTime.Parse(rdr["FechaIngreso"].ToString());

                }
            }
            return personal;
        }

        public void DeleteStudent(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
