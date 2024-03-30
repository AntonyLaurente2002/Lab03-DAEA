namespace Lab03
{
    partial class Persona
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
            btnListar = new Button();
            txtNombre = new TextBox();
            btnBuscar = new Button();
            dgvListado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(12, 22);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(102, 23);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 23);
            txtNombre.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(335, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(102, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvListado
            // 
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(12, 71);
            dgvListado.Name = "dgvListado";
            dgvListado.RowTemplate.Height = 25;
            dgvListado.Size = new Size(425, 340);
            dgvListado.TabIndex = 3;
            // 
            // Persona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 435);
            Controls.Add(dgvListado);
            Controls.Add(btnBuscar);
            Controls.Add(txtNombre);
            Controls.Add(btnListar);
            Name = "Persona";
            Text = "Persona";
            Load += Persona_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListar;
        private TextBox txtNombre;
        private Button btnBuscar;
        private DataGridView dgvListado;
    }
}