namespace ProyectoColegio
{
    partial class VentanaUniforme
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrecio = new TextBox();
            cbPrenda = new ComboBox();
            cbTalla = new ComboBox();
            btnRegistrarUniforme = new Button();
            btnSalir = new Button();
            label5 = new Label();
            dgvResultados = new DataGridView();
            dgvPrenda = new DataGridViewTextBoxColumn();
            dgvTalla = new DataGridViewTextBoxColumn();
            dgvPrecio = new DataGridViewTextBoxColumn();
            dgvCantidad = new DataGridViewTextBoxColumn();
            dgvTotal = new DataGridViewTextBoxColumn();
            cbCantidad = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 105);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "PRENDA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 198);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "TALLA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 198);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 2;
            label3.Text = "CANTIDAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 105);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "PRECIO";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(364, 136);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(148, 27);
            txtPrecio.TabIndex = 5;
            // 
            // cbPrenda
            // 
            cbPrenda.FormattingEnabled = true;
            cbPrenda.Items.AddRange(new object[] { "Camisa", "Pantalón", "Buzo", "Falda", "Casaca" });
            cbPrenda.Location = new Point(111, 135);
            cbPrenda.Name = "cbPrenda";
            cbPrenda.Size = new Size(135, 28);
            cbPrenda.TabIndex = 7;
            cbPrenda.SelectedIndexChanged += cbPrenda_SelectedIndexChanged;
            // 
            // cbTalla
            // 
            cbTalla.FormattingEnabled = true;
            cbTalla.Items.AddRange(new object[] { "XS", "S", "M", "L" });
            cbTalla.Location = new Point(108, 221);
            cbTalla.Name = "cbTalla";
            cbTalla.Size = new Size(138, 28);
            cbTalla.TabIndex = 8;
            // 
            // btnRegistrarUniforme
            // 
            btnRegistrarUniforme.Location = new Point(581, 67);
            btnRegistrarUniforme.Name = "btnRegistrarUniforme";
            btnRegistrarUniforme.Size = new Size(164, 96);
            btnRegistrarUniforme.TabIndex = 9;
            btnRegistrarUniforme.Text = "REGISTRAR UNIFORME";
            btnRegistrarUniforme.UseVisualStyleBackColor = true;
            btnRegistrarUniforme.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(581, 169);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(164, 96);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(225, 21);
            label5.Name = "label5";
            label5.Size = new Size(346, 41);
            label5.TabIndex = 11;
            label5.Text = "VENTA DE UNIFORMES";
            // 
            // dgvResultados
            // 
            dgvResultados.AllowUserToDeleteRows = false;
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Columns.AddRange(new DataGridViewColumn[] { dgvPrenda, dgvTalla, dgvPrecio, dgvCantidad, dgvTotal });
            dgvResultados.Location = new Point(57, 293);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.ReadOnly = true;
            dgvResultados.RowHeadersWidth = 51;
            dgvResultados.Size = new Size(678, 240);
            dgvResultados.TabIndex = 12;
            // 
            // dgvPrenda
            // 
            dgvPrenda.HeaderText = "PRENDA";
            dgvPrenda.MinimumWidth = 6;
            dgvPrenda.Name = "dgvPrenda";
            dgvPrenda.ReadOnly = true;
            dgvPrenda.Width = 125;
            // 
            // dgvTalla
            // 
            dgvTalla.HeaderText = "TALLA";
            dgvTalla.MinimumWidth = 6;
            dgvTalla.Name = "dgvTalla";
            dgvTalla.ReadOnly = true;
            dgvTalla.Width = 125;
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
            // cbCantidad
            // 
            cbCantidad.FormattingEnabled = true;
            cbCantidad.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cbCantidad.Location = new Point(364, 221);
            cbCantidad.Name = "cbCantidad";
            cbCantidad.Size = new Size(148, 28);
            cbCantidad.TabIndex = 13;
            // 
            // VentanaUniforme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 545);
            Controls.Add(cbCantidad);
            Controls.Add(dgvResultados);
            Controls.Add(label5);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrarUniforme);
            Controls.Add(cbTalla);
            Controls.Add(cbPrenda);
            Controls.Add(txtPrecio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VentanaUniforme";
            Text = "Venta de Uniformes";
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrecio;
        private ComboBox cbPrenda;
        private ComboBox cbTalla;
        private Button btnRegistrarUniforme;
        private Button btnSalir;
        private Label label5;
        private DataGridView dgvResultados;
        private ComboBox cbCantidad;
        private DataGridViewTextBoxColumn dgvPrenda;
        private DataGridViewTextBoxColumn dgvTalla;
        private DataGridViewTextBoxColumn dgvPrecio;
        private DataGridViewTextBoxColumn dgvCantidad;
        private DataGridViewTextBoxColumn dgvTotal;
    }
}