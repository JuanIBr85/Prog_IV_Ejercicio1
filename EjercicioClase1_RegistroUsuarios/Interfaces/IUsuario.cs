using EjercicioClase1_RegistroUsuarios.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase1_RegistroUsuarios.Interfaces
{
    public interface IUsuario
    {
        public List<Usuario> ObtenerUsuarios();
        public Usuario ObtenerUsuario(int idUsuario);
        public bool AltaUsuario (Usuario usuario);
        public bool ModificarUsuario(int idUsuaario, Usuario usuario);
        public bool BorradoUsuarioLogica(int idUsuario, Usuario usuario);
    }
}
