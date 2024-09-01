using EjercicioClase1_RegistroUsuarios.Interfaces;
using EjercicioClase1_RegistroUsuarios.Modelos;
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
    public partial class BajaUsuario : Form
    {
        private readonly IUsuario _usuario;
        public BajaUsuario(IUsuario usuario)
        {   
            _usuario = usuario;
            InitializeComponent();
        }
        Usuario usuario = new Usuario();
        private void btnBuscarIdUsuario_Click(object sender, EventArgs e)
        {
            int usuarioPorId = Convert.ToInt32(numericUpDownBajaUsuarioId.Value);

            if (usuarioPorId > 0)
            {
                Usuario usuarioID = new Usuario();
                usuarioID = _usuario.ObtenerUsuario(usuarioPorId);

                dataGridViewBajaIdUsuario.Rows.Clear();

                dataGridViewBajaIdUsuario.Rows.Add(usuarioID.ID_Usuario, usuarioID.Nombre, usuarioID.Apellido, usuarioID.Edad, usuarioID.FechaNacimiento,
                usuarioID.EmailUsuario, usuarioID.Telefono);

            }
            else
            {
                MessageBox.Show("Ingrese un Id de usuario valido.");
            }

        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            Usuario usuarioBaja = new Usuario();
            try
            {
                int idUsuarioBaja = Convert.ToInt32(numericUpDownBajaUsuarioId.Value);
   
                usuarioBaja.Borrado = true;

                bool exito = _usuario.BorradoUsuarioLogica(idUsuarioBaja, usuarioBaja);

                if (exito)
                {
                    MessageBox.Show("Baja Exitosa");
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la baja del usuario seleccionado");
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

    }
}
