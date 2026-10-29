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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaUniforme));
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
            label6 = new Label();
            label7 = new Label();
            txtTotal = new TextBox();
            txtCantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(64, 104);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "PRENDA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(64, 174);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "TALLA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(315, 172);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 2;
            label3.Text = "CANTIDAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(315, 101);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "PRECIO";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(409, 101);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(148, 27);
            txtPrecio.TabIndex = 5;
            // 
            // cbPrenda
            // 
            cbPrenda.FormattingEnabled = true;
            cbPrenda.Items.AddRange(new object[] { "Camisa", "Pantalón", "Buzo", "Falda", "Casaca" });
            cbPrenda.Location = new Point(148, 101);
            cbPrenda.Name = "cbPrenda";
            cbPrenda.Size = new Size(135, 28);
            cbPrenda.TabIndex = 7;
            cbPrenda.SelectedIndexChanged += cbPrenda_SelectedIndexChanged;
            // 
            // cbTalla
            // 
            cbTalla.FormattingEnabled = true;
            cbTalla.Items.AddRange(new object[] { "XS", "S", "M", "L" });
            cbTalla.Location = new Point(148, 169);
            cbTalla.Name = "cbTalla";
            cbTalla.Size = new Size(138, 28);
            cbTalla.TabIndex = 8;
            // 
            // btnRegistrarUniforme
            // 
            btnRegistrarUniforme.Location = new Point(600, 59);
            btnRegistrarUniforme.Name = "btnRegistrarUniforme";
            btnRegistrarUniforme.Size = new Size(119, 70);
            btnRegistrarUniforme.TabIndex = 9;
            btnRegistrarUniforme.Text = "REGISTRAR UNIFORME";
            btnRegistrarUniforme.UseVisualStyleBackColor = true;
            btnRegistrarUniforme.Click += button1_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(600, 145);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(119, 69);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(348, 7);
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
            dgvResultados.Location = new Point(64, 239);
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
            cbCantidad.Location = new Point(409, 166);
            cbCantidad.Name = "cbCantidad";
            cbCantidad.Size = new Size(148, 28);
            cbCantidad.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(787, 72);
            label6.Name = "label6";
            label6.Size = new Size(202, 20);
            label6.TabIndex = 14;
            label6.Text = "CANTIDAD DE UNIFORMES";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(859, 225);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 15;
            label7.Text = "TOTAL";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(802, 257);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(174, 27);
            txtTotal.TabIndex = 16;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(802, 104);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(174, 27);
            txtCantidad.TabIndex = 17;
            // 
            // VentanaUniforme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1030, 490);
            Controls.Add(txtCantidad);
            Controls.Add(txtTotal);
            Controls.Add(label7);
            Controls.Add(label6);
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
        private Label label6;
        private Label label7;
        private TextBox txtTotal;
        private TextBox txtCantidad;
    }
}