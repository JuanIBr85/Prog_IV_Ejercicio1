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
        public BajaUsuario()
        {
            InitializeComponent();
        }
        Usuario usuario = new Usuario();
        private void btnBuscarIdUsuario_Click(object sender, EventArgs e)
        {
            int usuarioPorId = Convert.ToInt32(numericUpDownBajaUsuarioId.Value);

            if (usuarioPorId > 0)
            {
                Usuario usuarioID = new Usuario();
                usuarioID = usuarioID.ObtenerUsuario(usuarioPorId);

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

                if(idUsuarioBaja == 0) 
                {
                    MessageBox.Show("Ingresar un id de usuario valido.");
                }
                else
                {   
                    usuarioBaja.Borrado = true;
                }

                bool exito = usuario.BorradoUsuarioLogica(idUsuarioBaja,usuarioBaja);

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
