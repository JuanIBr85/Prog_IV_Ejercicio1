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
        public Boolean Borrado { get; set; }


        // Metodo que devuelve al lista de usuarios
        public List<Usuario> ObtenerUsuarios()
        {
            ConexionBD conexionBD = new ConexionBD();

            string conexion = conexionBD.conectionString();

            string consultaBD = "Select ID_Usuario,Nombre, Apellido, Edad, FechaNacimiento, Email, Telefono from Usuarios WHERE Borrado = 0;";

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

        //Metodo que muestra un usuario determinado, a travez de si IdUsuario
        public Usuario ObtenerUsuario(int idUsuario)
        {
            ConexionBD conexionBD = new ConexionBD();
            string conexion = conexionBD.conectionString();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT ID_Usuario, Nombre, Apellido, Edad, FechaNacimiento, Email, Telefono FROM Usuarios ");
            stringBuilder.Append("WHERE ID_Usuario = @ID_Usuario AND Borrado = 0 ");

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

        //Metodo para dar de alta un nuevo usuario
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

        //Metodo para modificar alguno de los datos de un usuario existente.
        public bool ModificarUsuario(int idUsuario, Usuario usuario)
        {
            ConexionBD conexionBD = new ConexionBD();
            string conexion = conexionBD.conectionString();

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("UPDATE Usuarios SET ");

            // Armado de la consulta en la BD en funcion del/ los atributo/s a modificar

            List<string> atributo = new List<string>();

            if(!string.IsNullOrEmpty(usuario.Nombre)) atributo.Add("Nombre = @Nombre");
            if (!string.IsNullOrEmpty(usuario.Apellido)) atributo.Add("Apellido = @Apellido");
            if (usuario.Edad > 0) atributo.Add("Edad = @Edad");
            if (usuario.FechaNacimiento != DateTime.MinValue) atributo.Add("FechaNacimiento = @FechaNacimiento");
            if (!string.IsNullOrEmpty(usuario.EmailUsuario)) atributo.Add("Email = @Email");
            if (!string.IsNullOrEmpty(usuario.Telefono)) atributo.Add("Telefono = @Telefono");

            stringBuilder.Append(string.Join(", ", atributo));
            stringBuilder.Append(" WHERE ID_Usuario = @ID_Usuario");

            string consulta = stringBuilder.ToString();

           //Console.WriteLine("El string de conxion es " + consulta);

            bool exito = false;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(conexion))
                {
                    sqlConnection.Open();
                    using(SqlCommand sqlCommand = new SqlCommand(consulta,sqlConnection)) 
                    {
                        sqlCommand.Parameters.AddWithValue("@ID_Usuario", idUsuario);

                        if (!string.IsNullOrEmpty(usuario.Nombre)) sqlCommand.Parameters.AddWithValue("@Nombre",usuario.Nombre);
                        if (!string.IsNullOrEmpty(usuario.Apellido)) sqlCommand.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                        if (usuario.Edad > 0) sqlCommand.Parameters.AddWithValue("@Edad", usuario.Edad);
                        if (!string.IsNullOrEmpty(usuario.EmailUsuario)) sqlCommand.Parameters.AddWithValue("@Email", usuario.EmailUsuario);
                        if (!string.IsNullOrEmpty(usuario.Telefono)) sqlCommand.Parameters.AddWithValue("@Telefono", usuario.Telefono);
                        
                        //DateTime fechaNacimiento = usuario.FechaNacimiento;

                        if (usuario.FechaNacimiento < (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue || usuario.FechaNacimiento > (DateTime)System.Data.SqlTypes.SqlDateTime.MaxValue)
                        {
                           
                            sqlCommand.Parameters.AddWithValue("@FechaNacimiento", DBNull.Value);
                        }
                        else
                        {
                            sqlCommand.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                        }


                        sqlCommand.ExecuteNonQuery();
                    }
                }
                exito = true;
            }
            catch (Exception ex) 
            
            {
                throw new Exception(ex.Message);
            }

            return exito;
        }
        
        public bool BorradoUsuarioLogica (int idUsuario, Usuario usuario)
        {
            ConexionBD conexionBD = new ConexionBD();
            string conexion = conexionBD.conectionString();

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("UPDATE Usuarios SET Borrado = @Borrado ");
            stringBuilder.Append("WHERE ID_Usuario = @ID_Usuario ");

            string consulta = stringBuilder.ToString();

           bool exito = false;

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(conexion))
                {
                     sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(consulta,sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                        sqlCommand.Parameters.AddWithValue("@Borrado",usuario.Borrado);

                        sqlCommand.ExecuteNonQuery();
                    }
                }
                exito= true;
            }
            
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return exito;
        }
        
    }
}
