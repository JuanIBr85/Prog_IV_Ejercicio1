using EjercicioClase1_RegistroUsuarios.Clases;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase1_RegistroUsuarios.Modelos
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string EmailUsuario { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Edad { get; set; }
        public string RolUsuario { get; set; }



        public List<Usuario> ObtenerUsuarios()
        {
            ConexionBD conexionBD = new ConexionBD();

            string conexion = conexionBD.conectionString();

            string consultaBD = "Select ID_Usuario,Nombre, Apellido, Edad, FechaNacimiento, Email, Telefono from Usuarios;";

            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(conexion))
                {
                    // abrir la conexion con la DB

                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(consultaBD, sqlConnection))
                    {
                        //
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario()
                                {
                                    ID_Usuario = reader.GetInt32(0),
                                    Nombre = reader.GetString(1),
                                    Apellido = reader.GetString(2),
                                    Edad = reader.GetInt32(3),
                                    FechaNacimiento = reader.GetDateTime(4),
                                    EmailUsuario = reader.GetString(5),
                                };

                                if (!reader.IsDBNull(6))
                                {
                                    usuario.Telefono = reader.GetString(6);
                                }
                                else
                                {
                                    usuario.Telefono = null;
                                }

                                usuarios.Add(usuario);
                            }
                        }
                    }

                }
            }

            catch (Exception ex)
            {

                throw new Exception(ex.Message);

            }
            return usuarios;
        }

        public Usuario ObtenerUsuario(int idUsuario)
        {
            ConexionBD conexionBD = new ConexionBD();
            string conexion = conexionBD.conectionString();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT ID_Usuario, Nombre, Apellido, Edad, FechaNacimiento, Email, Telefono FROM Usuarios ");
            stringBuilder.Append("WHERE ID_Usuario = @ID_Usuario");

            string consulta = stringBuilder.ToString();

            Usuario usuario = new Usuario();

            try
            {
                using (SqlConnection sqlConection = new SqlConnection(conexion))
                {
                    sqlConection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConection))
                    {
                        sqlCommand.Parameters.AddWithValue("@ID_Usuario", idUsuario);

                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                usuario.ID_Usuario = reader.GetInt32(0);
                                usuario.Nombre = reader.GetString(1);
                                usuario.Apellido = reader.GetString(2);
                                usuario.Edad = reader.GetInt32(3);
                                usuario.FechaNacimiento = reader.GetDateTime(4);
                                usuario.EmailUsuario = reader.GetString(5);

                                if (!reader.IsDBNull(6))
                                {
                                    usuario.Telefono = reader.GetString(6);
                                }
                                else
                                {
                                    usuario.Telefono = null;
                                }

                            }
                        }

                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return usuario;
        }

        public bool AltaUsuario(Usuario usuario)
        {
            ConexionBD conexionBD = new ConexionBD();
            string conexion = conexionBD.conectionString();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("INSERT INTO Usuarios (Nombre,Apellido,Edad,FechaNacimiento,Email,Telefono) ");
            stringBuilder.Append("VALUES (@Nombre,@Apellido,@Edad,@FechaNacimiento,@Email,@Telefono);");

            string consulta = stringBuilder.ToString();

            bool exitoso = false;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(conexion))
                {

                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(consulta, sqlConnection))
                    {   
                        sqlCommand.Parameters.AddWithValue("@Nombre",usuario.Nombre);
                        sqlCommand.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        sqlCommand.Parameters.AddWithValue("@Edad", usuario.Edad);
                        sqlCommand.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                        sqlCommand.Parameters.AddWithValue("@Email", usuario.EmailUsuario);
                        sqlCommand.Parameters.AddWithValue("@Telefono", usuario.Telefono);

                        sqlCommand.ExecuteNonQuery();
                    }
                }
                exitoso = true;
               
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);

            }
            return exitoso;
        }
    }
}
