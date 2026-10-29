namespace ProyectoColegio
{
    partial class VentanaLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaLibros));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegistrarLibro = new Button();
            btnSalir = new Button();
            dgvResultados = new DataGridView();
            dgvLibro = new DataGridViewTextBoxColumn();
            dgvPrecio = new DataGridViewTextBoxColumn();
            dgvCantidad = new DataGridViewTextBoxColumn();
            dgvTotal = new DataGridViewTextBoxColumn();
            txtPrecio = new TextBox();
            cbLibro = new ComboBox();
            cbCantidad = new ComboBox();
            label5 = new Label();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(418, 18);
            label1.Name = "label1";
            label1.Size = new Size(273, 41);
            label1.TabIndex = 0;
            label1.Text = "VENTA DE LIBROS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 111);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "LIBRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 171);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "PRECIO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 226);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "CANTIDAD";
            // 
            // btnRegistrarLibro
            // 
            btnRegistrarLibro.Location = new Point(432, 80);
            btnRegistrarLibro.Name = "btnRegistrarLibro";
            btnRegistrarLibro.Size = new Size(110, 85);
            btnRegistrarLibro.TabIndex = 7;
            btnRegistrarLibro.Text = "REGISTRAR LIBRO";
            btnRegistrarLibro.UseVisualStyleBackColor = true;
            btnRegistrarLibro.Click += btnRegistrarLibro_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(432, 180);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 85);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToAddRows = false;
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { dgvLibro, dgvPrecio, dgvCantidad, dgvTotal });
            dgvResultados.Location = new Point(49, 271);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(554, 212);
            dgvResultados.TabIndex = 9;
            // 
            // dgvLibro
            // 
            dgvLibro.HeaderText = "LIBRO";
            dgvLibro.MinimumWidth = 6;
            dgvLibro.Name = "dgvLibro";
            dgvLibro.ReadOnly = true;
            dgvLibro.Width = 125;
            // 
            // dgvPrecio
            // 
            dgvPrecio.HeaderText = "PRECIO";
            dgvPrecio.MinimumWidth = 6;
            dgvPrecio.Name = "dgvPrecio";
            dgvPrecio.ReadOnly = true;
            dgvPrecio.Width = 125;
            // 
            // dgvCantidad
            // 
            dgvCantidad.HeaderText = "CANTIDAD";
            dgvCantidad.MinimumWidth = 6;
            dgvCantidad.Name = "dgvCantidad";
            dgvCantidad.ReadOnly = true;
            dgvCantidad.Width = 125;
            // 
            // dgvTotal
            // 
            dgvTotal.HeaderText = "TOTAL";
            dgvTotal.MinimumWidth = 6;
            dgvTotal.Name = "dgvTotal";
            dgvTotal.ReadOnly = true;
            dgvTotal.Width = 125;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(143, 164);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(210, 27);
            txtPrecio.TabIndex = 5;
            // 
            // cbLibro
            // 
            cbLibro.FormattingEnabled = true;
            cbLibro.Items.AddRange(new object[] { "Matemáticas", "Comunicación", "Ciencias", "Historia", "Biología" });
            cbLibro.Location = new Point(143, 108);
            cbLibro.Name = "cbLibro";
            cbLibro.Size = new Size(210, 28);
            cbLibro.TabIndex = 10;
            cbLibro.SelectedIndexChanged += cbLibro_SelectedIndexChanged;
            // 
            // cbCantidad
            // 
            cbCantidad.FormattingEnabled = true;
            cbCantidad.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbCantidad.Location = new Point(143, 218);
            cbCantidad.Name = "cbCantidad";
            cbCantidad.Size = new Size(210, 28);
            cbCantidad.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(593, 145);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 12;
            label5.Text = "TOTAL A PAGAR";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(584, 180);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(143, 27);
            txtTotal.TabIndex = 13;
            // 
            // VentanaLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1026, 492);
            Controls.Add(txtTotal);
            Controls.Add(label5);
            Controls.Add(cbCantidad);
            Controls.Add(cbLibro);
            Controls.Add(dgvResultados);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarLibro);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentanaLibros";
            Text = "Venta de Libros";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegistrarLibro;
        private Button btnSalir;
        private DataGridView dgvResultados;
        private DataGridViewTextBoxColumn dgvLibro;
        private DataGridViewTextBoxColumn dgvPrecio;
        private DataGridViewTextBoxColumn dgvCantidad;
        private DataGridViewTextBoxColumn dgvTotal;
        private TextBox txtPrecio;
        private ComboBox cbLibro;
        private ComboBox cbCantidad;
        private Label label5;
        private TextBox txtTotal;
    }
}