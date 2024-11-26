using Microsoft.IdentityModel.Protocols;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
// Data/CalificacionDAL.cs
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using TareasRecordManagementSystem.Models;
using TareasRecordManagementSystem.Utility;

namespace TareasRecordManagementSystem.Data
{
    public class TareaDAL
    {
        //private readonly string connectionString = ConfigurationManager.ConnectionStrings["RegistroCalificaciones"].ConnectionString;
        string connectionString = ConnectionString.CName;

        public List<Tarea> ObtenerTareas()
        {
            List<Tarea> calificaciones = new List<Tarea>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerTareas", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    calificaciones.Add(new Tarea
                    {
                        Id = (int)reader["Id"],
                        Titulo = reader["Titulo"].ToString(),
                        Descripcion = reader["Descripcion"].ToString()
                    });
                }
            }
            return calificaciones;
        }

        public void InsertarCalificacion(Tarea calificacion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarTarea", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Titulo", calificacion.Titulo);
                cmd.Parameters.AddWithValue("@Descripcion", calificacion.Descripcion);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ActualizarTarea(Tarea calificacion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarTarea", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", calificacion.Id);
                cmd.Parameters.AddWithValue("@Titulo", calificacion.Titulo);
                cmd.Parameters.AddWithValue("@Descripcion", calificacion.Descripcion);
                cmd.Parameters.AddWithValue("@estado", calificacion.Estado);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarCalificacion(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarCalificacion", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Tarea ObtenerCalificacionesEdit(int id)
        {
            Tarea calificacion = null; // Inicializar la variable como null para manejar si no se encuentra una calificación.

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ObtenerTareaEdit", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id); // Agregar el parámetro id.

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) // Usar if en lugar de while porque esperamos solo un resultado.
                {
                    calificacion = new Tarea
                    {
                        Id = (int)reader["Id"],
                        Descripcion   = reader["Titulo"].ToString(),
                        Titulo = reader["Descripcion"].ToString(),
                        Estado   = (bool)reader["estado"]

                    };
                }
                reader.Close(); // Asegurarse de cerrar el reader después de usarlo.
            }

            return calificacion; // Devolver el objeto calificacion o null si no se encontró.
        }
    }
}

