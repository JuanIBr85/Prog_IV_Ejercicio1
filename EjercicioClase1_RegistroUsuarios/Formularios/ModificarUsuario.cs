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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }
        Usuario usuario = new Usuario();
        private void btnActualizarUsuario_Click(object sender, EventArgs e)

        {
            Usuario actualizacionUsuario = new Usuario();
            try
            {
                int idUsuarioMod = Convert.ToInt32(numericUpDown1IdUsuario.Value);

                if (idUsuarioMod == 0)
                {
                    MessageBox.Show("Ingresar un Id de usuario valido");
                }
                else
                {
                    //MessageBox.Show("Id de usuario valido");

                    if (textBoxNombre.Text.Length > 0 && checkBoxOkNombre.Checked)
                        actualizacionUsuario.Nombre = textBoxNombre.Text;
                    if (textBoxApellido.Text.Length > 0 && checkBoxOkApellido.Checked)
                        actualizacionUsuario.Apellido = textBoxApellido.Text;
                    if (textBoxEmail.Text.Length > 0 && checkBoxOkMail.Checked)
                        actualizacionUsuario.EmailUsuario = textBoxEmail.Text;
                    if (intEdad.Value > 0 && checkBoxOkEdad.Checked)
                        actualizacionUsuario.Edad = intEdad.Value;
                    if (checkBoxOkFecha.Checked)
                    {
                        DateTime nuevaFechaNacimiento = dateTimePickerFechaNacimiento.Value;
                        if (nuevaFechaNacimiento > DateTime.Now)
                            MessageBox.Show("No se admiten fechas futuras");
                        if (nuevaFechaNacimiento < dateTimePickerFechaNacimiento.MinDate)
                            MessageBox.Show("Fecha invalida.");

                        actualizacionUsuario.FechaNacimiento = nuevaFechaNacimiento;
                    }
                    if (textBox1Telefono.Text.Length > 0 && checkBoxOkTelefono.Checked)
                        actualizacionUsuario.Telefono = textBox1Telefono.Text;

                }
                bool exito = usuario.ModificarUsuario(idUsuarioMod, actualizacionUsuario);

                if (exito)
                {
                    MessageBox.Show("Actualizacion exitosa");
                }
                else
                {
                    MessageBox.Show("No se pudo actulizar la información del usuario");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            FormularioInicio menuPricipalFormulario = new FormularioInicio();
            menuPricipalFormulario.Show();
        }
    }
}
