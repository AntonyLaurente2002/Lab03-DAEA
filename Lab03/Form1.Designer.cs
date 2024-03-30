namespace Lab03
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblServidor = new Label();
            lblBasedeDatos = new Label();
            txtServidor = new TextBox();
            txtBaseDatos = new TextBox();
            chkAutenticacion = new CheckBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new Label();
            textBox1 = new TextBox();
            btnConectar = new Button();
            btnEstado = new Button();
            btnDesconectar = new Button();
            btnPersona = new Button();
            SuspendLayout();
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Location = new Point(12, 34);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(50, 15);
            lblServidor.TabIndex = 0;
            lblServidor.Text = "Servidor";
            // 
            // lblBasedeDatos
            // 
            lblBasedeDatos.AutoSize = true;
            lblBasedeDatos.Location = new Point(12, 95);
            lblBasedeDatos.Name = "lblBasedeDatos";
            lblBasedeDatos.Size = new Size(80, 15);
            lblBasedeDatos.TabIndex = 1;
            lblBasedeDatos.Text = "Base de Datos";
            // 
            // txtServidor
            // 
            txtServidor.CharacterCasing = CharacterCasing.Lower;
            txtServidor.Location = new Point(12, 52);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(190, 23);
            txtServidor.TabIndex = 2;
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Location = new Point(12, 113);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(190, 23);
            txtBaseDatos.TabIndex = 3;
            // 
            // chkAutenticacion
            // 
            chkAutenticacion.AutoSize = true;
            chkAutenticacion.Location = new Point(12, 156);
            chkAutenticacion.Name = "chkAutenticacion";
            chkAutenticacion.Size = new Size(153, 19);
            chkAutenticacion.TabIndex = 4;
            chkAutenticacion.Text = "Autenticación integrada";
            chkAutenticacion.UseVisualStyleBackColor = true;
            chkAutenticacion.CheckedChanged += chkAutenticacion_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 34);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 5;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.CharacterCasing = CharacterCasing.Lower;
            txtUsuario.Enabled = false;
            txtUsuario.Location = new Point(271, 52);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(190, 23);
            txtUsuario.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(271, 95);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(70, 15);
            txtPassword.TabIndex = 7;
            txtPassword.Text = "Contraseña:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(271, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 23);
            textBox1.TabIndex = 8;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(120, 196);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(75, 23);
            btnConectar.TabIndex = 9;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnEstado
            // 
            btnEstado.Location = new Point(201, 196);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(75, 23);
            btnEstado.TabIndex = 10;
            btnEstado.Text = "Estado";
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnDesconectar
            // 
            btnDesconectar.Enabled = false;
            btnDesconectar.Location = new Point(282, 196);
            btnDesconectar.Name = "btnDesconectar";
            btnDesconectar.Size = new Size(89, 23);
            btnDesconectar.TabIndex = 11;
            btnDesconectar.Text = "Desconectar";
            btnDesconectar.UseVisualStyleBackColor = true;
            btnDesconectar.Click += btnDesconectar_Click;
            // 
            // btnPersona
            // 
            btnPersona.Location = new Point(201, 231);
            btnPersona.Name = "btnPersona";
            btnPersona.Size = new Size(75, 23);
            btnPersona.TabIndex = 12;
            btnPersona.Text = "Personas";
            btnPersona.UseVisualStyleBackColor = true;
            btnPersona.Click += btnPersona_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 266);
            Controls.Add(btnPersona);
            Controls.Add(btnDesconectar);
            Controls.Add(btnEstado);
            Controls.Add(btnConectar);
            Controls.Add(textBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(chkAutenticacion);
            Controls.Add(txtBaseDatos);
            Controls.Add(txtServidor);
            Controls.Add(lblBasedeDatos);
            Controls.Add(lblServidor);
            Name = "Form1";
            Text = "Conexión a un origen de datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServidor;
        private Label lblBasedeDatos;
        private TextBox txtServidor;
        private TextBox txtBaseDatos;
        private CheckBox chkAutenticacion;
        private Label label1;
        private TextBox txtUsuario;
        private Label txtPassword;
        private TextBox textBox1;
        private Button btnConectar;
        private Button btnEstado;
        private Button btnDesconectar;
        private Button btnPersona;
    }
}