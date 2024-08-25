namespace EjercicioClase1_RegistroUsuarios.Formularios
{
    partial class AltaUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGuardarUsuario = new Button();
            labelRol = new Label();
            comboBoxRol = new ComboBox();
            checkBoxTelefono = new CheckBox();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            intEdad = new NumericUpDown();
            labelFechaNacimiento = new Label();
            labelEdad = new Label();
            textBoxTelefono = new TextBox();
            labelTelefono = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxApellido = new TextBox();
            labelApellido = new Label();
            textBoxNombre = new TextBox();
            labelNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)intEdad).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.Location = new Point(408, 371);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(158, 42);
            btnGuardarUsuario.TabIndex = 31;
            btnGuardarUsuario.Text = "Guardar";
            btnGuardarUsuario.UseVisualStyleBackColor = true;
            btnGuardarUsuario.Click += btnGuardarUsuario_Click;
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Location = new Point(21, 206);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(108, 20);
            labelRol.TabIndex = 30;
            labelRol.Text = "Rol del usuario";
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(205, 203);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(214, 28);
            comboBoxRol.TabIndex = 29;
            // 
            // checkBoxTelefono
            // 
            checkBoxTelefono.AutoSize = true;
            checkBoxTelefono.Location = new Point(21, 276);
            checkBoxTelefono.Name = "checkBoxTelefono";
            checkBoxTelefono.Size = new Size(103, 24);
            checkBoxTelefono.TabIndex = 28;
            checkBoxTelefono.Text = "¿Telefono?";
            checkBoxTelefono.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaNacimiento.Location = new Point(205, 162);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(214, 27);
            dateTimePickerFechaNacimiento.TabIndex = 27;
            dateTimePickerFechaNacimiento.Value = new DateTime(2024, 8, 15, 19, 5, 4, 0);
            // 
            // intEdad
            // 
            intEdad.Location = new Point(205, 125);
            intEdad.Name = "intEdad";
            intEdad.Size = new Size(210, 27);
            intEdad.TabIndex = 26;
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Location = new Point(21, 162);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(149, 20);
            labelFechaNacimiento.TabIndex = 25;
            labelFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(21, 132);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(43, 20);
            labelEdad.TabIndex = 24;
            labelEdad.Text = "Edad";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Enabled = false;
            textBoxTelefono.Location = new Point(191, 302);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(214, 27);
            textBoxTelefono.TabIndex = 23;
            textBoxTelefono.Visible = false;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Enabled = false;
            labelTelefono.Location = new Point(21, 308);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(146, 20);
            labelTelefono.TabIndex = 22;
            labelTelefono.Text = "Numero de Telefono";
            labelTelefono.Visible = false;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(205, 86);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(214, 27);
            textBoxEmail.TabIndex = 21;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(21, 89);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 20;
            labelEmail.Text = "Email";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(205, 48);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(214, 27);
            textBoxApellido.TabIndex = 19;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(21, 54);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(66, 20);
            labelApellido.TabIndex = 18;
            labelApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(205, 12);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(214, 27);
            textBoxNombre.TabIndex = 17;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(21, 18);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 16;
            labelNombre.Text = "Nombre";
            // 
            // AltaUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 450);
            Controls.Add(btnGuardarUsuario);
            Controls.Add(labelRol);
            Controls.Add(comboBoxRol);
            Controls.Add(checkBoxTelefono);
            Controls.Add(dateTimePickerFechaNacimiento);
            Controls.Add(intEdad);
            Controls.Add(labelFechaNacimiento);
            Controls.Add(labelEdad);
            Controls.Add(textBoxTelefono);
            Controls.Add(labelTelefono);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxApellido);
            Controls.Add(labelApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(labelNombre);
            Name = "AltaUsuario";
            Text = "AltaUsuario";
            ((System.ComponentModel.ISupportInitialize)intEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarUsuario;
        private Label labelRol;
        private ComboBox comboBoxRol;
        private CheckBox checkBoxTelefono;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private NumericUpDown intEdad;
        private Label labelFechaNacimiento;
        private Label labelEdad;
        private TextBox textBoxTelefono;
        private Label labelTelefono;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxApellido;
        private Label labelApellido;
        private TextBox textBoxNombre;
        private Label labelNombre;
    }
}