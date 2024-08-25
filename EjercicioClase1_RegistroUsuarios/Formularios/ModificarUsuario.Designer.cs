namespace EjercicioClase1_RegistroUsuarios.Formularios
{
    partial class ModificarUsuario
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
            btnActualizarUsuario = new Button();
            textBox1Telefono = new TextBox();
            labelTelefono = new Label();
            labelRol = new Label();
            comboBoxRol = new ComboBox();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            intEdad = new NumericUpDown();
            labelFechaNacimiento = new Label();
            labelEdad = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxApellido = new TextBox();
            labelApellido = new Label();
            textBoxNombre = new TextBox();
            labelNombre = new Label();
            label1ModIdUsuario = new Label();
            checkBoxOkNombre = new CheckBox();
            checkBoxOkApellido = new CheckBox();
            checkBoxOkMail = new CheckBox();
            checkBoxOkEdad = new CheckBox();
            checkBoxOkFecha = new CheckBox();
            checkBoxOkTelefono = new CheckBox();
            checkBoxOkRoll = new CheckBox();
            numericUpDown1IdUsuario = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)intEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1IdUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnActualizarUsuario
            // 
            btnActualizarUsuario.Location = new Point(419, 363);
            btnActualizarUsuario.Name = "btnActualizarUsuario";
            btnActualizarUsuario.Size = new Size(164, 29);
            btnActualizarUsuario.TabIndex = 0;
            btnActualizarUsuario.Text = "Actualizar";
            btnActualizarUsuario.UseVisualStyleBackColor = true;
            btnActualizarUsuario.Click += btnActualizarUsuario_Click;
            // 
            // textBox1Telefono
            // 
            textBox1Telefono.Location = new Point(213, 247);
            textBox1Telefono.Name = "textBox1Telefono";
            textBox1Telefono.Size = new Size(152, 27);
            textBox1Telefono.TabIndex = 48;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(29, 250);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(67, 20);
            labelTelefono.TabIndex = 47;
            labelTelefono.Text = "Telefono";
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Location = new Point(29, 292);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(108, 20);
            labelRol.TabIndex = 46;
            labelRol.Text = "Rol del usuario";
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(213, 289);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(214, 28);
            comboBoxRol.TabIndex = 45;
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaNacimiento.Location = new Point(213, 204);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(214, 27);
            dateTimePickerFechaNacimiento.TabIndex = 43;
            dateTimePickerFechaNacimiento.Value = new DateTime(2024, 8, 25, 0, 0, 0, 0);
            // 
            // intEdad
            // 
            intEdad.Location = new Point(213, 167);
            intEdad.Name = "intEdad";
            intEdad.Size = new Size(210, 27);
            intEdad.TabIndex = 42;
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Location = new Point(29, 204);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(149, 20);
            labelFechaNacimiento.TabIndex = 41;
            labelFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(29, 169);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(43, 20);
            labelEdad.TabIndex = 40;
            labelEdad.Text = "Edad";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(213, 128);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(214, 27);
            textBoxEmail.TabIndex = 39;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(29, 131);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 38;
            labelEmail.Text = "Email";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(213, 90);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(214, 27);
            textBoxApellido.TabIndex = 37;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(29, 96);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(66, 20);
            labelApellido.TabIndex = 36;
            labelApellido.Text = "Apellido";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(213, 54);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(214, 27);
            textBoxNombre.TabIndex = 35;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(29, 60);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 34;
            labelNombre.Text = "Nombre";
            // 
            // label1ModIdUsuario
            // 
            label1ModIdUsuario.AutoSize = true;
            label1ModIdUsuario.Location = new Point(29, 18);
            label1ModIdUsuario.Name = "label1ModIdUsuario";
            label1ModIdUsuario.Size = new Size(76, 20);
            label1ModIdUsuario.TabIndex = 49;
            label1ModIdUsuario.Text = "Id Usuario";
            // 
            // checkBoxOkNombre
            // 
            checkBoxOkNombre.AutoSize = true;
            checkBoxOkNombre.Location = new Point(441, 54);
            checkBoxOkNombre.Name = "checkBoxOkNombre";
            checkBoxOkNombre.Size = new Size(95, 24);
            checkBoxOkNombre.TabIndex = 51;
            checkBoxOkNombre.Text = "Modificar";
            checkBoxOkNombre.UseVisualStyleBackColor = true;
            // 
            // checkBoxOkApellido
            // 
            checkBoxOkApellido.AutoSize = true;
            checkBoxOkApellido.Location = new Point(441, 91);
            checkBoxOkApellido.Name = "checkBoxOkApellido";
            checkBoxOkApellido.Size = new Size(95, 24);
            checkBoxOkApellido.TabIndex = 52;
            checkBoxOkApellido.Text = "Modificar";
            checkBoxOkApellido.UseVisualStyleBackColor = true;
            // 
            // checkBoxOkMail
            // 
            checkBoxOkMail.AutoSize = true;
            checkBoxOkMail.Location = new Point(439, 131);
            checkBoxOkMail.Name = "checkBoxOkMail";
            checkBoxOkMail.Size = new Size(95, 24);
            checkBoxOkMail.TabIndex = 53;
            checkBoxOkMail.Text = "Modificar";
            checkBoxOkMail.UseVisualStyleBackColor = true;
            // 
            // checkBoxOkEdad
            // 
            checkBoxOkEdad.AutoSize = true;
            checkBoxOkEdad.Location = new Point(441, 167);
            checkBoxOkEdad.Name = "checkBoxOkEdad";
            checkBoxOkEdad.Size = new Size(95, 24);
            checkBoxOkEdad.TabIndex = 54;
            checkBoxOkEdad.Text = "Modificar";
            checkBoxOkEdad.UseVisualStyleBackColor = true;
            // 
            // checkBoxOkFecha
            // 
            checkBoxOkFecha.AutoSize = true;
            checkBoxOkFecha.Location = new Point(439, 203);
            checkBoxOkFecha.Name = "checkBoxOkFecha";
            checkBoxOkFecha.Size = new Size(95, 24);
            checkBoxOkFecha.TabIndex = 55;
            checkBoxOkFecha.Text = "Modificar";
            checkBoxOkFecha.UseVisualStyleBackColor = true;
            // 
            // checkBoxOkTelefono
            // 
            checkBoxOkTelefono.AutoSize = true;
            checkBoxOkTelefono.Location = new Point(439, 246);
            checkBoxOkTelefono.Name = "checkBoxOkTelefono";
            checkBoxOkTelefono.Size = new Size(95, 24);
            checkBoxOkTelefono.TabIndex = 56;
            checkBoxOkTelefono.Text = "Modificar";
            checkBoxOkTelefono.UseVisualStyleBackColor = true;
            // 
            // checkBoxOkRoll
            // 
            checkBoxOkRoll.AutoSize = true;
            checkBoxOkRoll.Location = new Point(441, 291);
            checkBoxOkRoll.Name = "checkBoxOkRoll";
            checkBoxOkRoll.Size = new Size(95, 24);
            checkBoxOkRoll.TabIndex = 57;
            checkBoxOkRoll.Text = "Modificar";
            checkBoxOkRoll.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1IdUsuario
            // 
            numericUpDown1IdUsuario.Location = new Point(215, 16);
            numericUpDown1IdUsuario.Name = "numericUpDown1IdUsuario";
            numericUpDown1IdUsuario.Size = new Size(67, 27);
            numericUpDown1IdUsuario.TabIndex = 58;
            // 
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 435);
            Controls.Add(numericUpDown1IdUsuario);
            Controls.Add(checkBoxOkRoll);
            Controls.Add(checkBoxOkTelefono);
            Controls.Add(checkBoxOkFecha);
            Controls.Add(checkBoxOkEdad);
            Controls.Add(checkBoxOkMail);
            Controls.Add(checkBoxOkApellido);
            Controls.Add(checkBoxOkNombre);
            Controls.Add(label1ModIdUsuario);
            Controls.Add(textBox1Telefono);
            Controls.Add(labelTelefono);
            Controls.Add(labelRol);
            Controls.Add(comboBoxRol);
            Controls.Add(dateTimePickerFechaNacimiento);
            Controls.Add(intEdad);
            Controls.Add(labelFechaNacimiento);
            Controls.Add(labelEdad);
            Controls.Add(textBoxEmail);
            Controls.Add(labelEmail);
            Controls.Add(textBoxApellido);
            Controls.Add(labelApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(labelNombre);
            Controls.Add(btnActualizarUsuario);
            KeyPreview = true;
            Name = "ModificarUsuario";
            Text = "ModificarUsuario";
            ((System.ComponentModel.ISupportInitialize)intEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1IdUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizarUsuario;
        private TextBox textBox1Telefono;
        private Label labelTelefono;
        private Label labelRol;
        private ComboBox comboBoxRol;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private NumericUpDown intEdad;
        private Label labelFechaNacimiento;
        private Label labelEdad;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxApellido;
        private Label labelApellido;
        private TextBox textBoxNombre;
        private Label labelNombre;
        private Label label1ModIdUsuario;
        private CheckBox checkBoxOkNombre;
        private CheckBox checkBoxOkApellido;
        private CheckBox checkBoxOkMail;
        private CheckBox checkBoxOkEdad;
        private CheckBox checkBoxOkFecha;
        private CheckBox checkBoxOkTelefono;
        private CheckBox checkBoxOkRoll;
        private NumericUpDown numericUpDown1IdUsuario;
    }
}