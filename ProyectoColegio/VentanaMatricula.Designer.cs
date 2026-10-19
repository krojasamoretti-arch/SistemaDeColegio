namespace ProyectoColegio
{
    partial class VentanaMatricula
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtDni = new TextBox();
            txtApoderado = new TextBox();
            txtMonto = new TextBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            dgvResultados = new DataGridView();
            dgvNombre = new DataGridViewTextBoxColumn();
            dgvDNI = new DataGridViewTextBoxColumn();
            dgvGRADO = new DataGridViewTextBoxColumn();
            dgvAPODERADO = new DataGridViewTextBoxColumn();
            dgvMonto = new DataGridViewTextBoxColumn();
            cbGrado = new ComboBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 34);
            label1.Name = "label1";
            label1.Size = new Size(391, 41);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE MATRICULA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "DNI:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 196);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 3;
            label4.Text = "GRADO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 242);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 4;
            label5.Text = "APODERADO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 286);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 5;
            label6.Text = "MONTO:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 106);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(247, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(119, 155);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(247, 27);
            txtDni.TabIndex = 7;
            // 
            // txtApoderado
            // 
            txtApoderado.Location = new Point(119, 235);
            txtApoderado.Name = "txtApoderado";
            txtApoderado.Size = new Size(247, 27);
            txtApoderado.TabIndex = 9;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(119, 279);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(247, 27);
            txtMonto.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(396, 106);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(142, 94);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR MATRICULA";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(596, 106);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(142, 94);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(500, 212);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(142, 94);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { dgvNombre, dgvDNI, dgvGRADO, dgvAPODERADO, dgvMonto });
            dgvResultados.Location = new Point(49, 331);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(713, 211);
            dgvResultados.TabIndex = 14;
            // 
            // dgvNombre
            // 
            dgvNombre.HeaderText = "NOMBRE";
            dgvNombre.MinimumWidth = 6;
            dgvNombre.Name = "dgvNombre";
            dgvNombre.ReadOnly = true;
            dgvNombre.Width = 130;
            // 
            // dgvDNI
            // 
            dgvDNI.HeaderText = "DNI";
            dgvDNI.MinimumWidth = 6;
            dgvDNI.Name = "dgvDNI";
            dgvDNI.ReadOnly = true;
            dgvDNI.Width = 130;
            // 
            // dgvGRADO
            // 
            dgvGRADO.HeaderText = "GRADO";
            dgvGRADO.MinimumWidth = 6;
            dgvGRADO.Name = "dgvGRADO";
            dgvGRADO.ReadOnly = true;
            dgvGRADO.Width = 140;
            // 
            // dgvAPODERADO
            // 
            dgvAPODERADO.HeaderText = "APODERADO";
            dgvAPODERADO.MinimumWidth = 6;
            dgvAPODERADO.Name = "dgvAPODERADO";
            dgvAPODERADO.ReadOnly = true;
            dgvAPODERADO.Width = 130;
            // 
            // dgvMonto
            // 
            dgvMonto.HeaderText = "MONTO";
            dgvMonto.MinimumWidth = 6;
            dgvMonto.Name = "dgvMonto";
            dgvMonto.ReadOnly = true;
            dgvMonto.Width = 130;
            // 
            // cbGrado
            // 
            cbGrado.FormattingEnabled = true;
            cbGrado.Items.AddRange(new object[] { "Primero Secundaria", "Segundo Secundaria", "Tercero Secundaria", "Cuarto Secundaria", "Quinto Secundaria" });
            cbGrado.Location = new Point(119, 201);
            cbGrado.Name = "cbGrado";
            cbGrado.Size = new Size(247, 28);
            cbGrado.TabIndex = 15;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // VentanaMatricula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 554);
            Controls.Add(cbGrado);
            Controls.Add(dgvResultados);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(txtMonto);
            Controls.Add(txtApoderado);
            Controls.Add(txtDni);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentanaMatricula";
            Text = "VentanaMatricula";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtDni;
        private TextBox txtApoderado;
        private TextBox txtMonto;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnSalir;
        private DataGridView dgvResultados;
        private ComboBox cbGrado;
        private DataGridViewTextBoxColumn dgvNombre;
        private DataGridViewTextBoxColumn dgvDNI;
        private DataGridViewTextBoxColumn dgvGRADO;
        private DataGridViewTextBoxColumn dgvAPODERADO;
        private DataGridViewTextBoxColumn dgvMonto;
        private ContextMenuStrip contextMenuStrip1;
    }
}
