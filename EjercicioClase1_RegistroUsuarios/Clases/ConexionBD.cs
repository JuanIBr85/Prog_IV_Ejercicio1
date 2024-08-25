using EjercicioClase1_RegistroUsuarios.Modelos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase1_RegistroUsuarios.Clases
{
    public class ConexionBD
    {
        public string conectionString()
        {
            string conexion = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProgramacionIV;Data Source=JIMIFLOYDPAD\\SQLEXPRESS;Trusted_Connection=True;TrustServerCertificate=True";
            return conexion;
        }
    }
}