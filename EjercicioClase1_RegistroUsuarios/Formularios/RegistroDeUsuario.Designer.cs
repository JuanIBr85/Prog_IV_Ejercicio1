namespace EjercicioClase1_RegistroUsuarios.Formularios
{
    partial class RegistroDeUsuario
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
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            labelApellido = new Label();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            textBoxTelefono = new TextBox();
            labelTelefono = new Label();
            labelEdad = new Label();
            labelFechaNacimiento = new Label();
            intEdad = new NumericUpDown();
            dateTimePickerFechaNacimiento = new DateTimePicker();
            checkBoxTelefono = new CheckBox();
            comboBoxRol = new ComboBox();
            labelRol = new Label();
            buttonGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)intEdad).BeginInit();
            SuspendLayout();
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(14, 32);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(62, 18);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(198, 26);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(214, 24);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(198, 62);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(214, 24);
            textBoxApellido.TabIndex = 3;
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(14, 68);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(59, 18);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Apellido";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(198, 100);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(214, 24);
            textBoxEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(14, 103);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(45, 18);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Enabled = false;
            textBoxTelefono.Location = new Point(184, 316);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(214, 24);
            textBoxTelefono.TabIndex = 7;
            textBoxTelefono.Visible = false;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Enabled = false;
            labelTelefono.Location = new Point(14, 322);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(144, 18);
            labelTelefono.TabIndex = 6;
            labelTelefono.Text = "Numero de Telefono";
            labelTelefono.Visible = false;
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(14, 140);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(42, 18);
            labelEdad.TabIndex = 8;
            labelEdad.Text = "Edad";
            // 
            // labelFechaNacimiento
            // 
            labelFechaNacimiento.AutoSize = true;
            labelFechaNacimiento.Location = new Point(14, 176);
            labelFechaNacimiento.Name = "labelFechaNacimiento";
            labelFechaNacimiento.Size = new Size(148, 18);
            labelFechaNacimiento.TabIndex = 9;
            labelFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // intEdad
            // 
            intEdad.Location = new Point(198, 139);
            intEdad.Name = "intEdad";
            intEdad.Size = new Size(210, 24);
            intEdad.TabIndex = 10;
            // 
            // dateTimePickerFechaNacimiento
            // 
            dateTimePickerFechaNacimiento.Format = DateTimePickerFormat.Short;
            dateTimePickerFechaNacimiento.Location = new Point(198, 176);
            dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            dateTimePickerFechaNacimiento.Size = new Size(214, 24);
            dateTimePickerFechaNacimiento.TabIndex = 11;
            dateTimePickerFechaNacimiento.Value = new DateTime(2024, 8, 15, 19, 5, 4, 0);
            // 
            // checkBoxTelefono
            // 
            checkBoxTelefono.AutoSize = true;
            checkBoxTelefono.Location = new Point(14, 290);
            checkBoxTelefono.Name = "checkBoxTelefono";
            checkBoxTelefono.Size = new Size(104, 22);
            checkBoxTelefono.TabIndex = 12;
            checkBoxTelefono.Text = "¿Telefono?";
            checkBoxTelefono.UseVisualStyleBackColor = true;
            checkBoxTelefono.CheckedChanged += checkBoxTelefono_CheckedChanged;
            // 
            // comboBoxRol
            // 
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Location = new Point(198, 217);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(214, 26);
            comboBoxRol.TabIndex = 13;
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Location = new Point(14, 220);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(107, 18);
            labelRol.TabIndex = 14;
            labelRol.Text = "Rol del usuario";
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(430, 368);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(158, 42);
            buttonGuardar.TabIndex = 15;
            buttonGuardar.Text = "Mostrar Datos";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // RegistroDeUsuario
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(638, 436);
            Controls.Add(buttonGuardar);
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
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "RegistroDeUsuario";
            Text = "Alta de Usuario";
            ((System.ComponentModel.ISupportInitialize)intEdad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombre;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private Label labelApellido;
        private TextBox textBoxEmail;
        private Label labelEmail;
        private TextBox textBoxTelefono;
        private Label labelTelefono;
        private Label labelEdad;
        private Label labelFechaNacimiento;
        private NumericUpDown intEdad;
        private DateTimePicker dateTimePickerFechaNacimiento;
        private CheckBox checkBoxTelefono;
        private ComboBox comboBoxRol;
        private Label labelRol;
        private Button buttonGuardar;
    }
}