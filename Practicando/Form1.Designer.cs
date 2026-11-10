namespace Practicando
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
            btnCargar = new Button();
            dgvDatos = new DataGridView();
            dgvCodigo = new DataGridViewTextBoxColumn();
            dgvCurso = new DataGridViewTextBoxColumn();
            dgvArea = new DataGridViewTextBoxColumn();
            dgvCosto = new DataGridViewTextBoxColumn();
            dgvVacantes = new DataGridViewTextBoxColumn();
            dgvDisponibilidad = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtCodigo = new TextBox();
            btnBuscar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblCurso = new Label();
            lblArea = new Label();
            lblCosto = new Label();
            lblVacantes = new Label();
            btnResumen = new Button();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.Location = new Point(208, 35);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(160, 72);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargar cursos";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { dgvCodigo, dgvCurso, dgvArea, dgvCosto, dgvVacantes, dgvDisponibilidad });
            dgvDatos.Location = new Point(29, 127);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.Size = new Size(803, 392);
            dgvDatos.TabIndex = 1;
            // 
            // dgvCodigo
            // 
            dgvCodigo.HeaderText = "CÓDIGO";
            dgvCodigo.MinimumWidth = 6;
            dgvCodigo.Name = "dgvCodigo";
            dgvCodigo.ReadOnly = true;
            dgvCodigo.Width = 125;
            // 
            // dgvCurso
            // 
            dgvCurso.HeaderText = "CURSO";
            dgvCurso.MinimumWidth = 6;
            dgvCurso.Name = "dgvCurso";
            dgvCurso.ReadOnly = true;
            dgvCurso.Width = 125;
            // 
            // dgvArea
            // 
            dgvArea.HeaderText = "ÁREA";
            dgvArea.MinimumWidth = 6;
            dgvArea.Name = "dgvArea";
            dgvArea.ReadOnly = true;
            dgvArea.Width = 125;
            // 
            // dgvCosto
            // 
            dgvCosto.HeaderText = "COSTO";
            dgvCosto.MinimumWidth = 6;
            dgvCosto.Name = "dgvCosto";
            dgvCosto.ReadOnly = true;
            dgvCosto.Width = 125;
            // 
            // dgvVacantes
            // 
            dgvVacantes.HeaderText = "VACANTES";
            dgvVacantes.MinimumWidth = 6;
            dgvVacantes.Name = "dgvVacantes";
            dgvVacantes.ReadOnly = true;
            dgvVacantes.Width = 125;
            // 
            // dgvDisponibilidad
            // 
            dgvDisponibilidad.HeaderText = "DISPONIBILIDAD";
            dgvDisponibilidad.MinimumWidth = 6;
            dgvDisponibilidad.Name = "dgvDisponibilidad";
            dgvDisponibilidad.ReadOnly = true;
            dgvDisponibilidad.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(857, 62);
            label1.Name = "label1";
            label1.Size = new Size(73, 23);
            label1.TabIndex = 2;
            label1.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(936, 58);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(163, 27);
            txtCodigo.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1105, 56);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 31);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(857, 183);
            label2.Name = "label2";
            label2.Size = new Size(60, 23);
            label2.TabIndex = 5;
            label2.Text = "Curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(857, 237);
            label3.Name = "label3";
            label3.Size = new Size(52, 23);
            label3.TabIndex = 6;
            label3.Text = "Área:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(857, 291);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 7;
            label4.Text = "Costo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(857, 343);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 8;
            label5.Text = "Vacantes:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(992, 127);
            label6.Name = "label6";
            label6.Size = new Size(117, 23);
            label6.TabIndex = 9;
            label6.Text = "RESULTADOS";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurso.Location = new Point(923, 183);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(52, 23);
            lblCurso.TabIndex = 10;
            lblCurso.Text = "------";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(923, 237);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(52, 23);
            lblArea.TabIndex = 11;
            lblArea.Text = "------";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCosto.Location = new Point(923, 291);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(52, 23);
            lblCosto.TabIndex = 12;
            lblCosto.Text = "------";
            // 
            // lblVacantes
            // 
            lblVacantes.AutoSize = true;
            lblVacantes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVacantes.Location = new Point(947, 343);
            lblVacantes.Name = "lblVacantes";
            lblVacantes.Size = new Size(52, 23);
            lblVacantes.TabIndex = 13;
            lblVacantes.Text = "------";
            // 
            // btnResumen
            // 
            btnResumen.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResumen.Location = new Point(525, 38);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(160, 72);
            btnResumen.TabIndex = 14;
            btnResumen.Text = "Ver Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(838, 405);
            label7.Name = "label7";
            label7.Size = new Size(379, 138);
            label7.TabIndex = 15;
            label7.Text = "CRÉDITOS\r\nDesarrollado por: Kevin Henry Rojas Amoretti\r\nCódigo: N00550370\r\nCurso: FUNDAMENTOS DE PROGRAMACION\r\nSección: 26697\r\n\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(838, 382);
            label8.Name = "label8";
            label8.Size = new Size(416, 23);
            label8.TabIndex = 16;
            label8.Text = "----------------------------------------------------------";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 540);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnResumen);
            Controls.Add(lblVacantes);
            Controls.Add(lblCosto);
            Controls.Add(lblArea);
            Controls.Add(lblCurso);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBuscar);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Controls.Add(dgvDatos);
            Controls.Add(btnCargar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargar;
        private DataGridView dgvDatos;
        private Label label1;
        private TextBox txtCodigo;
        private Button btnBuscar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblCurso;
        private Label lblArea;
        private Label lblCosto;
        private Label lblVacantes;
        private Button btnResumen;
        private Label label7;
        private Label label8;
        private DataGridViewTextBoxColumn dgvCodigo;
        private DataGridViewTextBoxColumn dgvCurso;
        private DataGridViewTextBoxColumn dgvArea;
        private DataGridViewTextBoxColumn dgvCosto;
        private DataGridViewTextBoxColumn dgvVacantes;
        private DataGridViewTextBoxColumn dgvDisponibilidad;
    }
}
