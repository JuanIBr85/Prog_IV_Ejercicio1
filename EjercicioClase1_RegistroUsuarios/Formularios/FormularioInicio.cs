using EjercicioClase1_RegistroUsuarios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase1_RegistroUsuarios.Formularios
{
    public partial class FormularioInicio : Form
    {
        private readonly IUsuario _usario;
        public FormularioInicio(IUsuario usuario)
        {
             _usario = usuario;
            InitializeComponent();
        }

        private void btnBusquedaUsuario_Click(object sender, EventArgs e)
        {
            ObtenerDatos obtenerDatosFormulario = new ObtenerDatos(_usario);

            obtenerDatosFormulario.Show();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUsuarioFormulario = new AltaUsuario(_usario);

            altaUsuarioFormulario.Show();
        }

        private void btnModUsuario_Click(object sender, EventArgs e)
        {
            ModificarUsuario modificarUsuarioFormulario = new ModificarUsuario(_usario );
            modificarUsuarioFormulario.Show();
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            BajaUsuario bajaUsuarioFormularios = new BajaUsuario(_usario);
            bajaUsuarioFormularios.Show();
        }
    }
}
