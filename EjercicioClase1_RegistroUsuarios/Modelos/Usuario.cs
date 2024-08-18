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
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string EmailUsuario { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public decimal Edad {  get; set; }
        public string RolUsuario { get; set; } 

    }
}
