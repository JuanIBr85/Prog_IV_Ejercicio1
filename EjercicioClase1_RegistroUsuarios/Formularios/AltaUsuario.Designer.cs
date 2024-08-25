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
            checkBoxTelUsuario = new CheckBox();
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
            labelTelefono = new Label();
            textBox1Telefono = new TextBox();
            ((System.ComponentModel.ISupportInitialize)intEdad).BeginInit();
            SuspendLayout();
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.Location = new Point(350, 367);
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
            // checkBoxTelUsuario
            // 
            checkBoxTelUsuario.AutoSize = true;
            checkBoxTelUsuario.Location = new Point(21, 276);
            checkBoxTelUsuario.Name = "checkBoxTelUsuario";
            checkBoxTelUsuario.Size = new Size(103, 24);
            checkBoxTelUsuario.TabIndex = 28;
            checkBoxTelUsuario.Text = "¿Telefono?";
            checkBoxTelUsuario.UseVisualStyleBackColor = true;
            checkBoxTelUsuario.CheckedChanged += checkBoxTelUsuario_CheckedChanged;
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
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Enabled = false;
            labelTelefono.Location = new Point(21, 319);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(67, 20);
            labelTelefono.TabIndex = 32;
            labelTelefono.Text = "Telefono";
            labelTelefono.Visible = false;
            // 
            // textBox1Telefono
            // 
            textBox1Telefono.Enabled = false;
            textBox1Telefono.Location = new Point(205, 316);
            textBox1Telefono.Name = "textBox1Telefono";
            textBox1Telefono.Size = new Size(152, 27);
            textBox1Telefono.TabIndex = 33;
            textBox1Telefono.Visible = false;
            // 
            // AltaUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 450);
            Controls.Add(textBox1Telefono);
            Controls.Add(labelTelefono);
            Controls.Add(btnGuardarUsuario);
            Controls.Add(labelRol);
            Controls.Add(comboBoxRol);
            Controls.Add(checkBoxTelUsuario);
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
            Name = "AltaUsuario";
            Text = "Alta Usuario";
            ((System.ComponentModel.ISupportInitialize)intEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarUsuario;
        private Label labelRol;
        private ComboBox comboBoxRol;
        private CheckBox checkBoxTelUsuario;
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
        private Label labelTelefono;
        private TextBox textBox1Telefono;
    }
}