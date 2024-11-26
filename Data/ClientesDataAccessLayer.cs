using TareasRecordManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace TareasRecordManagementSystem.Models
{
    public class ClientesDataAccessLayer
    {

        string connectionString = ConnectionString.CName;

        public IEnumerable<Cliente> GetAllClientes()
        {
            List<Cliente> lstStudent = new List<Cliente>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //SqlCommand cmd = new SqlCommand("spGetAllPersonal", con);
                SqlCommand cmd = new SqlCommand("ListarClientes", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Cliente student = new Cliente();

                    student.IDCliente = Convert.ToInt32(rdr["IDCliente"]);
                    student.Nombre = rdr["Nombre"].ToString();
                    student.Apellido = rdr["Apellido"].ToString();
                    student.Email = rdr["Email"].ToString();


                    lstStudent.Add(student);
                }
                con.Close();
            }
            return lstStudent;
        }
        

        //ListarClientes
        public void AddCliente(Cliente cliente)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("RegistrarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@p_Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@p_Email", cliente.Email);
                //cmd.Parameters.AddWithValue("@p_Clave", null);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

       
        public void UpdateStudent(Cliente cliente)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ModificarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@p_IDCliente", cliente.IDCliente);
                cmd.Parameters.AddWithValue("@p_Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@p_Apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@p_Email", cliente.Email);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public Cliente GetClienteData(int? id)
        {
            Cliente  cliente = new Cliente();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM Clientes WHERE IDCliente= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cliente.IDCliente = Convert.ToInt32(rdr["IDCliente"]);
                    cliente.Nombre = rdr["Nombre"].ToString();
                    cliente.Apellido = rdr["Apellido"].ToString();
                    cliente.Email = rdr["Email"].ToString();
                }
            }
            return cliente;
        }

        public void DeleteCliente(int? id)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("EliminarCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_IDCliente", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

