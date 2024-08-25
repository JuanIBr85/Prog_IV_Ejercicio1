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
        public FormularioInicio()
        {
            InitializeComponent();
        }

        private void btnBusquedaUsuario_Click(object sender, EventArgs e)
        {
            ObtenerDatos obtenerDatosFormulario = new ObtenerDatos();

            obtenerDatosFormulario.Show();
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            AltaUsuario altaUsuarioFormulario = new AltaUsuario();

            altaUsuarioFormulario.Show();
        }
    }
}
