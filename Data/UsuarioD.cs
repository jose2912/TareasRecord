using TareasRecordManagementSystem.Models;
using TareasRecordManagementSystem.Utility;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using CapaConexion;

namespace TareasRecordManagementSystem.Data
{
    public class UsuarioD
    {
        Conexion cn = new Conexion();
        string connectionString = ConnectionString.CName;

        //private string cadena = "Data Source=.;Initial Catalog=BDControlEstacionamientos;Integrated Security=True";

        public IEnumerable<Usuario> GetAllAutos()
        {
            List<Usuario> lstUsuario = new List<Usuario>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("ListarAutosPorCliente", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Usuario auto = new Usuario();
                    auto.Username = rdr["Username"].ToString();
                    auto.Clave = rdr["Clave"].ToString();
                    lstUsuario.Add(auto);
                }
                con.Close();
            }
            return lstUsuario;
        }
        //public DataTable IniciarSesion(Usuario usuario)
        //{

        //    DataTable dt = new DataTable();
        //    // para hacer un login se hace de esta manera
        //    SqlCommand cmd = new SqlCommand("ValidarAcceso", cn.conectar_db());
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@p_Username", usuario.Username);
        //    cmd.Parameters.AddWithValue("@p_Clave", usuario.Clave);

        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(dt);
        //    return dt;

        //}

        public DataTable IniciarSesion(Usuario usuario)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = cn.conectar_db())
            {
                using (SqlCommand cmd = new SqlCommand("ValidarAcceso", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_Username", usuario.Username);
                    cmd.Parameters.AddWithValue("@p_Clave", usuario.Clave);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            // Verificar si el DataTable tiene datos o si es un valor específico como 0
            if (dt.Rows.Count > 0 && dt.Columns.Contains("Resultado"))
            {
                int resultado = Convert.ToInt32(dt.Rows[0]["Resultado"]);
                if (resultado == 0)
                {
                    // No hay coincidencias, retorno de sesión no válida
                    return null;
                }
            }

            // Si hay datos en el DataTable, se retornan (sesión válida)
            return dt;
        }

        public void AddUsuario(Cliente cliente)
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

    }
}

