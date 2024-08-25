namespace EjercicioClase1_RegistroUsuarios.Formularios
{
    partial class ObtenerDatos
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
            components = new System.ComponentModel.Container();
            btnObtenerDatos = new Button();
            dataGridViewUsuarios = new DataGridView();
            IdUsuario = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            FechaNacimiemto = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            usuarioBindingSource = new BindingSource(components);
            label1IdUsuario = new Label();
            numericUpDown1IdUsuario = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1IdUsuario).BeginInit();
            SuspendLayout();
            // 
            // btnObtenerDatos
            // 
            btnObtenerDatos.Location = new Point(908, 507);
            btnObtenerDatos.Name = "btnObtenerDatos";
            btnObtenerDatos.Size = new Size(157, 52);
            btnObtenerDatos.TabIndex = 0;
            btnObtenerDatos.Text = "Obtener Datos";
            btnObtenerDatos.UseVisualStyleBackColor = true;
            btnObtenerDatos.Click += btnObtenerDatos_Click;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { IdUsuario, Nombre, Apellido, Edad, FechaNacimiemto, Email, Telefono });
            dataGridViewUsuarios.Location = new Point(12, 92);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.Size = new Size(1053, 400);
            dataGridViewUsuarios.TabIndex = 1;
            // 
            // IdUsuario
            // 
            IdUsuario.Frozen = true;
            IdUsuario.HeaderText = "Id Usuario";
            IdUsuario.MinimumWidth = 6;
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            IdUsuario.Width = 125;
            // 
            // Nombre
            // 
            Nombre.Frozen = true;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.Frozen = true;
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            Apellido.Width = 125;
            // 
            // Edad
            // 
            Edad.Frozen = true;
            Edad.HeaderText = "Edad";
            Edad.MinimumWidth = 6;
            Edad.Name = "Edad";
            Edad.ReadOnly = true;
            Edad.Width = 125;
            // 
            // FechaNacimiemto
            // 
            FechaNacimiemto.Frozen = true;
            FechaNacimiemto.HeaderText = "Fecha de nacimineto";
            FechaNacimiemto.MinimumWidth = 6;
            FechaNacimiemto.Name = "FechaNacimiemto";
            FechaNacimiemto.ReadOnly = true;
            FechaNacimiemto.Width = 125;
            // 
            // Email
            // 
            Email.Frozen = true;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // Telefono
            // 
            Telefono.Frozen = true;
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            Telefono.Width = 125;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Modelos.Usuario);
            // 
            // label1IdUsuario
            // 
            label1IdUsuario.AutoSize = true;
            label1IdUsuario.Location = new Point(33, 30);
            label1IdUsuario.Name = "label1IdUsuario";
            label1IdUsuario.Size = new Size(101, 20);
            label1IdUsuario.TabIndex = 2;
            label1IdUsuario.Text = "Id del Usuario";
            // 
            // numericUpDown1IdUsuario
            // 
            numericUpDown1IdUsuario.Location = new Point(140, 28);
            numericUpDown1IdUsuario.Name = "numericUpDown1IdUsuario";
            numericUpDown1IdUsuario.Size = new Size(91, 27);
            numericUpDown1IdUsuario.TabIndex = 3;
            // 
            // ObtenerDatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 591);
            Controls.Add(numericUpDown1IdUsuario);
            Controls.Add(label1IdUsuario);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(btnObtenerDatos);
            Name = "ObtenerDatos";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1IdUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnObtenerDatos;
        private DataGridView dataGridViewUsuarios;
        private BindingSource usuarioBindingSource;
        private Label label1IdUsuario;
        private NumericUpDown numericUpDown1IdUsuario;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn FechaNacimiemto;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefono;
    }
}