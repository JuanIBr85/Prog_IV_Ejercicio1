namespace EjercicioClase1_RegistroUsuarios.Formularios
{
    partial class BajaUsuario
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
            numericUpDownBajaUsuarioId = new NumericUpDown();
            btnBajaUsuario = new Button();
            label1 = new Label();
            checkBox1BajaUsuarioId = new CheckBox();
            dataGridViewBajaIdUsuario = new DataGridView();
            ID_Usuario = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            btnBuscarIdUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBajaUsuarioId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBajaIdUsuario).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownBajaUsuarioId
            // 
            numericUpDownBajaUsuarioId.Location = new Point(158, 34);
            numericUpDownBajaUsuarioId.Name = "numericUpDownBajaUsuarioId";
            numericUpDownBajaUsuarioId.Size = new Size(105, 27);
            numericUpDownBajaUsuarioId.TabIndex = 0;
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.Location = new Point(407, 261);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(181, 45);
            btnBajaUsuario.TabIndex = 2;
            btnBajaUsuario.Text = "Baja de usuario";
            btnBajaUsuario.UseVisualStyleBackColor = true;
            btnBajaUsuario.Click += btnBajaUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 41);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Id Usuario";
            // 
            // checkBox1BajaUsuarioId
            // 
            checkBox1BajaUsuarioId.AutoSize = true;
            checkBox1BajaUsuarioId.ForeColor = Color.Red;
            checkBox1BajaUsuarioId.Location = new Point(30, 88);
            checkBox1BajaUsuarioId.Name = "checkBox1BajaUsuarioId";
            checkBox1BajaUsuarioId.Size = new Size(130, 24);
            checkBox1BajaUsuarioId.TabIndex = 4;
            checkBox1BajaUsuarioId.Text = "Confirmar baja";
            checkBox1BajaUsuarioId.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBajaIdUsuario
            // 
            dataGridViewBajaIdUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBajaIdUsuario.Columns.AddRange(new DataGridViewColumn[] { ID_Usuario, Nombre, Apellido, Edad, FechaNacimiento, Email, Telefono });
            dataGridViewBajaIdUsuario.Location = new Point(30, 135);
            dataGridViewBajaIdUsuario.Name = "dataGridViewBajaIdUsuario";
            dataGridViewBajaIdUsuario.RowHeadersWidth = 51;
            dataGridViewBajaIdUsuario.Size = new Size(988, 120);
            dataGridViewBajaIdUsuario.TabIndex = 5;
            // 
            // ID_Usuario
            // 
            ID_Usuario.Frozen = true;
            ID_Usuario.HeaderText = "Id Usuario";
            ID_Usuario.MinimumWidth = 6;
            ID_Usuario.Name = "ID_Usuario";
            ID_Usuario.ReadOnly = true;
            ID_Usuario.Width = 97;
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
            // FechaNacimiento
            // 
            FechaNacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FechaNacimiento.Frozen = true;
            FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            FechaNacimiento.MinimumWidth = 6;
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.ReadOnly = true;
            FechaNacimiento.Width = 163;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Email.Frozen = true;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 75;
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
            // btnBuscarIdUsuario
            // 
            btnBuscarIdUsuario.Location = new Point(319, 34);
            btnBuscarIdUsuario.Name = "btnBuscarIdUsuario";
            btnBuscarIdUsuario.Size = new Size(152, 29);
            btnBuscarIdUsuario.TabIndex = 6;
            btnBuscarIdUsuario.Text = "Buscar Id";
            btnBuscarIdUsuario.UseVisualStyleBackColor = true;
            btnBuscarIdUsuario.Click += btnBuscarIdUsuario_Click;
            // 
            // BajaUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 333);
            Controls.Add(btnBuscarIdUsuario);
            Controls.Add(dataGridViewBajaIdUsuario);
            Controls.Add(checkBox1BajaUsuarioId);
            Controls.Add(label1);
            Controls.Add(btnBajaUsuario);
            Controls.Add(numericUpDownBajaUsuarioId);
            Name = "BajaUsuario";
            Text = "BajaUsuario";
            ((System.ComponentModel.ISupportInitialize)numericUpDownBajaUsuarioId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBajaIdUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownBajaUsuarioId;
        private Button btnBajaUsuario;
        private Label label1;
        private CheckBox checkBox1BajaUsuarioId;
        private DataGridView dataGridViewBajaIdUsuario;
        private Button btnBuscarIdUsuario;
        private DataGridViewTextBoxColumn ID_Usuario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefono;
    }
}