namespace EjercicioClase1_RegistroUsuarios.Formularios
{
    partial class FormularioInicio
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
            btnBusquedaUsuario = new Button();
            btnAltaUsuario = new Button();
            btnModUsuario = new Button();
            btnBajaUsuario = new Button();
            SuspendLayout();
            // 
            // btnBusquedaUsuario
            // 
            btnBusquedaUsuario.Location = new Point(131, 39);
            btnBusquedaUsuario.Name = "btnBusquedaUsuario";
            btnBusquedaUsuario.Size = new Size(128, 73);
            btnBusquedaUsuario.TabIndex = 0;
            btnBusquedaUsuario.Text = "Busqueda de Usuario";
            btnBusquedaUsuario.UseVisualStyleBackColor = true;
            btnBusquedaUsuario.Click += btnBusquedaUsuario_Click;
            // 
            // btnAltaUsuario
            // 
            btnAltaUsuario.Location = new Point(131, 137);
            btnAltaUsuario.Name = "btnAltaUsuario";
            btnAltaUsuario.Size = new Size(128, 66);
            btnAltaUsuario.TabIndex = 1;
            btnAltaUsuario.Text = "Alta de Usuario";
            btnAltaUsuario.UseVisualStyleBackColor = true;
            btnAltaUsuario.Click += btnAltaUsuario_Click;
            // 
            // btnModUsuario
            // 
            btnModUsuario.Location = new Point(131, 235);
            btnModUsuario.Name = "btnModUsuario";
            btnModUsuario.Size = new Size(128, 66);
            btnModUsuario.TabIndex = 2;
            btnModUsuario.Text = "Modificar Datos de Usuario";
            btnModUsuario.UseVisualStyleBackColor = true;
            btnModUsuario.Click += btnModUsuario_Click;
            // 
            // btnBajaUsuario
            // 
            btnBajaUsuario.Location = new Point(131, 331);
            btnBajaUsuario.Name = "btnBajaUsuario";
            btnBajaUsuario.Size = new Size(128, 66);
            btnBajaUsuario.TabIndex = 3;
            btnBajaUsuario.Text = "Baja de Usuario";
            btnBajaUsuario.UseVisualStyleBackColor = true;
            btnBajaUsuario.Click += btnBajaUsuario_Click;
            // 
            // FormularioInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 426);
            Controls.Add(btnBajaUsuario);
            Controls.Add(btnModUsuario);
            Controls.Add(btnAltaUsuario);
            Controls.Add(btnBusquedaUsuario);
            Name = "FormularioInicio";
            Text = "FormularioInicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBusquedaUsuario;
        private Button btnAltaUsuario;
        private Button btnModUsuario;
        private Button btnBajaUsuario;
    }
}