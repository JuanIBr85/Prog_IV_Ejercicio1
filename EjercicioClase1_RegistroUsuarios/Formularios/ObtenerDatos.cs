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
    public partial class ObtenerDatos : Form
    {
        public ObtenerDatos()
        {
            InitializeComponent();
        }

        Usuario usuario = new Usuario();
        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            GuardarPersonas();
        }

        private void GuardarPersonas()
        {
            dataGridViewUsuarios.Rows.Clear();

            if (numericUpDown1IdUsuario.Value == 0)
            {
                List<Usuario> usuarios = new List<Usuario>();
                usuarios = usuario.ObtenerUsuarios();

                foreach (var usuario in usuarios)
                {
                    dataGridViewUsuarios.Rows.Add(usuario.ID_Usuario,usuario.Nombre, usuario.Apellido, usuario.Edad, usuario.FechaNacimiento, usuario.EmailUsuario, usuario.Telefono);
                }

            } 
            else 
            {   
                int usuarioPorId = Convert.ToInt32(numericUpDown1IdUsuario.Value);

                Usuario usuarioID = new Usuario();
                usuarioID = usuarioID.ObtenerUsuario(usuarioPorId);

                dataGridViewUsuarios.Rows.Add(usuarioID.ID_Usuario, usuarioID.Nombre, usuarioID.Apellido, usuarioID.Edad, usuarioID.FechaNacimiento,
                    usuarioID.EmailUsuario, usuarioID.Telefono);
            }
                
        }
    }
} 
