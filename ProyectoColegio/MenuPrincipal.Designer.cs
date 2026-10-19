namespace ProyectoColegio
{
    partial class MenuPrincipal
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
            btnAbrirMatricula = new Button();
            btnAbrirVentas = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(826, 41);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA DE MESA DE PARTES - I.E.P SIR ISAAC NEWTON";
            // 
            // btnAbrirMatricula
            // 
            btnAbrirMatricula.Location = new Point(61, 224);
            btnAbrirMatricula.Name = "btnAbrirMatricula";
            btnAbrirMatricula.Size = new Size(200, 150);
            btnAbrirMatricula.TabIndex = 1;
            btnAbrirMatricula.Text = "REGISTRAR MATRICULAS";
            btnAbrirMatricula.UseVisualStyleBackColor = true;
            btnAbrirMatricula.Click += btnAbrirMatricula_Click;
            // 
            // btnAbrirVentas
            // 
            btnAbrirVentas.Location = new Point(349, 224);
            btnAbrirVentas.Name = "btnAbrirVentas";
            btnAbrirVentas.Size = new Size(200, 150);
            btnAbrirVentas.TabIndex = 2;
            btnAbrirVentas.Text = "REGISTRAR VENTAS";
            btnAbrirVentas.UseVisualStyleBackColor = true;
            btnAbrirVentas.Click += button2_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(635, 224);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 150);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button3_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 522);
            Controls.Add(btnSalir);
            Controls.Add(btnAbrirVentas);
            Controls.Add(btnAbrirMatricula);
            Controls.Add(label1);
            Name = "MenuPrincipal";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAbrirMatricula;
        private Button btnAbrirVentas;
        private Button btnSalir;
    }
}