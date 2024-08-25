using EjercicioClase1_RegistroUsuarios.Modelos;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase1_RegistroUsuarios.Formularios
{
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }
        Usuario usuario = new Usuario();
        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNombre.Text == "")
                    throw new Exception("Completar Nombre");
                if (textBoxApellido.Text == "")
                    throw new Exception("Completar Apellido");
                if (textBoxEmail.Text == "")
                    throw new Exception("Completar Email");
                if (intEdad.Value == 0)
                    throw new Exception("Completar la edad");
                if (checkBoxTelUsuario.Checked && textBox1Telefono.Text == "")
                    throw new Exception("Completar el numero de telefono");
                //if (comboBoxRol.Text == "")
                //  throw new Exception("Elegir un Rol");

                Usuario usuarioNuevo = new Usuario()
                {
                    Nombre = textBoxNombre.Text,
                    Apellido = textBoxApellido.Text,
                    Edad = intEdad.Value,
                    EmailUsuario = textBoxEmail.Text,
                    FechaNacimiento = dateTimePickerFechaNacimiento.Value,
                    Telefono = textBox1Telefono.Text,

                };

                bool exito = usuario.AltaUsuario(usuarioNuevo);

                if (exito)
                {
                    MessageBox.Show("Alta de usuario exitosa");
                }
                else
                {
                    MessageBox.Show("No se pudo dar de alta el usuario");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void checkBoxTelUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTelUsuario.Checked)
            {
                labelTelefono.Visible = true;
                labelTelefono.Enabled = true;
                textBox1Telefono.Visible=true;
                textBox1Telefono.Enabled=true;
            }
            else
            {
                labelTelefono.Visible = false;
                labelTelefono.Enabled = false;
                textBox1Telefono.Visible = false;
                textBox1Telefono.Enabled = false;
            }

        }
    }
}
