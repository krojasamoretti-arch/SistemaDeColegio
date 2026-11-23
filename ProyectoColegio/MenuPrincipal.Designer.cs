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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            lblTitulo = new Label();
            btnSalir = new Button();
            menuStrip1 = new MenuStrip();
            ToolStripMatricula = new ToolStripMenuItem();
            ToolStripLibros = new ToolStripMenuItem();
            ToolStripUniformes = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(109, 120);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(826, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE MESA DE PARTES - I.E.P SIR ISAAC NEWTON";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(396, 209);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 150);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ToolStripMatricula, ToolStripLibros, ToolStripUniformes });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1028, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMatricula
            // 
            ToolStripMatricula.Name = "ToolStripMatricula";
            ToolStripMatricula.Size = new Size(102, 24);
            ToolStripMatricula.Text = "MATRICULA";
            ToolStripMatricula.Click += rEGISTROToolStripMenuItem_Click;
            // 
            // ToolStripLibros
            // 
            ToolStripLibros.Name = "ToolStripLibros";
            ToolStripLibros.Size = new Size(71, 24);
            ToolStripLibros.Text = "LIBROS";
            ToolStripLibros.Click += ToolStripLibros_Click;
            // 
            // ToolStripUniformes
            // 
            ToolStripUniformes.Name = "ToolStripUniformes";
            ToolStripUniformes.Size = new Size(96, 24);
            ToolStripUniformes.Text = "UNIFORME";
            ToolStripUniformes.Click += ToolStripUniformes_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1028, 485);
            Controls.Add(btnSalir);
            Controls.Add(lblTitulo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnSalir;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ToolStripMatricula;
        private ToolStripMenuItem ToolStripLibros;
        private ToolStripMenuItem ToolStripUniformes;
    }
}