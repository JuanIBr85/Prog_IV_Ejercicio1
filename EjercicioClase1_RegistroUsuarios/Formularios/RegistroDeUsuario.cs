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
    public partial class RegistroDeUsuario : Form
    {
        Usuario usuario = new Usuario();// inicializa la clase Usuario.
        public RegistroDeUsuario()
        {
            InitializeComponent();

            List<string> RolesUsuario = new List<string>()
            {"Admin","Usuario","Invitado"};

            foreach (var rol in RolesUsuario)
            {
                comboBoxRol.Items.Add(rol);
            }

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                /*if (textBoxNombre.Text == "" || textBoxApellido.Text == "" || textBoxEmail.Text == "" || intEdad.Value == 0 || checkBoxTelefono.Checked && textBoxTelefono.Text == "")
                throw new Exception("Completar todos los campos");
                */

                if (textBoxNombre.Text == "")
                    throw new Exception("Completar Nombre");
                if (textBoxApellido.Text == "")
                    throw new Exception("Completar Apellido");
                if (textBoxEmail.Text == "")
                    throw new Exception("Completar Email");
                if (intEdad.Value == 0)
                    throw new Exception("Completar la edad");
                if (checkBoxTelefono.Checked && textBoxTelefono.Text == "")
                    throw new Exception("Completar el numero de telefono");
                if (comboBoxRol.Text == "")
                    throw new Exception("Elegir un Rol");

                usuario.Nombre = textBoxNombre.Text;
                usuario.Apellido = textBoxApellido.Text;
                usuario.EmailUsuario = textBoxEmail.Text;
                usuario.Edad = intEdad.Value;
                usuario.FechaNacimiento = dateTimePickerFechaNacimiento.Value;
                usuario.RolUsuario = comboBoxRol.Text;

                if (checkBoxTelefono.Checked)
                {
                    usuario.Telefono = textBoxTelefono.Text;

                    MessageBox.Show($"Datos del Usuario: \nNombre: {usuario.Nombre}" +
                     $"\nApellido: {usuario.Apellido}" +
                     $"\nEmail: {usuario.EmailUsuario}" +
                     $"\nTelefono: {usuario.Telefono}" +
                     $"\nEdad: {usuario.Edad}" +
                     $"\nFecha de nacimiento: {usuario.FechaNacimiento}" +
                     $"\nRol: {usuario.RolUsuario}");
                }
                else 
                {
                    MessageBox.Show($"Datos del Usuario: \nNombre: {usuario.Nombre}" +
                    $"\nApellido: {usuario.Apellido}" +
                    $"\nEmail: {usuario.EmailUsuario}" +
                    $"\nEdad: {usuario.Edad}" +
                    $"\nFecha de nacimiento: {usuario.FechaNacimiento}" +
                    $"\nRol: {usuario.RolUsuario}");
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void checkBoxTelefono_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTelefono.Checked)
            {
                labelTelefono.Enabled = true;
                labelTelefono.Visible = true;
                textBoxTelefono.Enabled = true;
                textBoxTelefono.Visible = true;
            }
            else 
            { 
                labelTelefono.Enabled = false;
                labelTelefono.Visible = false; 
                textBoxTelefono.Enabled = false; 
                textBoxTelefono.Visible = false; 
            }  
        }
    }
}
