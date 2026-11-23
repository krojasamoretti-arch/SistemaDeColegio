namespace LaboratorioFinal
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
            label1 = new Label();
            dgvResultados = new DataGridView();
            dgvCliente = new DataGridViewTextBoxColumn();
            dgvTelefono = new DataGridViewTextBoxColumn();
            dgvPaquete = new DataGridViewTextBoxColumn();
            dgvMonto = new DataGridViewTextBoxColumn();
            dgvMetodo = new DataGridViewTextBoxColumn();
            dgvTrabajador = new DataGridViewTextBoxColumn();
            btnRegistrar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCliente = new TextBox();
            txtTelefono = new TextBox();
            txtMonto = new TextBox();
            cbPaquete = new ComboBox();
            cbMetodo = new ComboBox();
            cbTrabajador = new ComboBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(472, 9);
            label1.Name = "label1";
            label1.Size = new Size(343, 28);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE REGISTRO DE VENTAS";
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { dgvCliente, dgvTelefono, dgvPaquete, dgvMonto, dgvMetodo, dgvTrabajador });
            dgvResultados.Location = new Point(12, 59);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(803, 472);
            dgvResultados.TabIndex = 1;
            // 
            // dgvCliente
            // 
            dgvCliente.HeaderText = "CLIENTE";
            dgvCliente.MinimumWidth = 6;
            dgvCliente.Name = "dgvCliente";
            dgvCliente.ReadOnly = true;
            dgvCliente.Width = 125;
            // 
            // dgvTelefono
            // 
            dgvTelefono.HeaderText = "TELEFONO";
            dgvTelefono.MinimumWidth = 6;
            dgvTelefono.Name = "dgvTelefono";
            dgvTelefono.ReadOnly = true;
            dgvTelefono.Width = 125;
            // 
            // dgvPaquete
            // 
            dgvPaquete.HeaderText = "TIPO DE PAQUETE";
            dgvPaquete.MinimumWidth = 6;
            dgvPaquete.Name = "dgvPaquete";
            dgvPaquete.ReadOnly = true;
            dgvPaquete.Width = 125;
            // 
            // dgvMonto
            // 
            dgvMonto.HeaderText = "MONTO";
            dgvMonto.MinimumWidth = 6;
            dgvMonto.Name = "dgvMonto";
            dgvMonto.ReadOnly = true;
            dgvMonto.Width = 125;
            // 
            // dgvMetodo
            // 
            dgvMetodo.HeaderText = "METODO DE PAGO";
            dgvMetodo.MinimumWidth = 6;
            dgvMetodo.Name = "dgvMetodo";
            dgvMetodo.ReadOnly = true;
            dgvMetodo.Width = 125;
            // 
            // dgvTrabajador
            // 
            dgvTrabajador.HeaderText = "TRABAJADOR";
            dgvTrabajador.MinimumWidth = 6;
            dgvTrabajador.Name = "dgvTrabajador";
            dgvTrabajador.ReadOnly = true;
            dgvTrabajador.Width = 125;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(824, 355);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(123, 58);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "REGISTRAR VENTA";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.Location = new Point(821, 59);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 3;
            label2.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.Location = new Point(824, 104);
            label3.Name = "label3";
            label3.Size = new Size(83, 23);
            label3.TabIndex = 4;
            label3.Text = "Telefono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label4.Location = new Point(824, 157);
            label4.Name = "label4";
            label4.Size = new Size(147, 23);
            label4.TabIndex = 5;
            label4.Text = "Tipo de paquete:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.Location = new Point(824, 207);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 6;
            label5.Text = "Monto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.Location = new Point(824, 253);
            label6.Name = "label6";
            label6.Size = new Size(149, 23);
            label6.TabIndex = 7;
            label6.Text = "Metodo de pago:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label7.Location = new Point(824, 304);
            label7.Name = "label7";
            label7.Size = new Size(103, 23);
            label7.TabIndex = 8;
            label7.Text = "Trabajador:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(977, 55);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(216, 27);
            txtCliente.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(977, 100);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(216, 27);
            txtTelefono.TabIndex = 10;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(977, 203);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(216, 27);
            txtMonto.TabIndex = 11;
            // 
            // cbPaquete
            // 
            cbPaquete.FormattingEnabled = true;
            cbPaquete.Items.AddRange(new object[] { "Video Normal", "Video Editado" });
            cbPaquete.Location = new Point(977, 152);
            cbPaquete.Name = "cbPaquete";
            cbPaquete.Size = new Size(216, 28);
            cbPaquete.TabIndex = 12;
            // 
            // cbMetodo
            // 
            cbMetodo.FormattingEnabled = true;
            cbMetodo.Items.AddRange(new object[] { "Efectivo", "Yape / Plin" });
            cbMetodo.Location = new Point(977, 252);
            cbMetodo.Name = "cbMetodo";
            cbMetodo.Size = new Size(216, 28);
            cbMetodo.TabIndex = 13;
            // 
            // cbTrabajador
            // 
            cbTrabajador.FormattingEnabled = true;
            cbTrabajador.Items.AddRange(new object[] { "Luigino Vizacarra", "Milagros Morales", "Pablo Reyes" });
            cbTrabajador.Location = new Point(977, 299);
            cbTrabajador.Name = "cbTrabajador";
            cbTrabajador.Size = new Size(216, 28);
            cbTrabajador.TabIndex = 14;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(953, 355);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(123, 58);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1079, 355);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(123, 58);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(950, 448);
            button1.Name = "button1";
            button1.Size = new Size(123, 58);
            button1.TabIndex = 17;
            button1.Text = "VER RESUMEN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 552);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(cbTrabajador);
            Controls.Add(cbMetodo);
            Controls.Add(cbPaquete);
            Controls.Add(txtMonto);
            Controls.Add(txtTelefono);
            Controls.Add(txtCliente);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvResultados);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvResultados;
        private Button btnRegistrar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCliente;
        private TextBox txtTelefono;
        private TextBox txtMonto;
        private ComboBox cbPaquete;
        private ComboBox cbMetodo;
        private ComboBox cbTrabajador;
        private Button btnLimpiar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn dgvCliente;
        private DataGridViewTextBoxColumn dgvTelefono;
        private DataGridViewTextBoxColumn dgvPaquete;
        private DataGridViewTextBoxColumn dgvMonto;
        private DataGridViewTextBoxColumn dgvMetodo;
        private DataGridViewTextBoxColumn dgvTrabajador;
        private Button button1;
    }
}
