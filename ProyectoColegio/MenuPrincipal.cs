using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoColegio
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        void Salir()
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrirMatricula_Click(object sender, EventArgs e)
        {
            VentanaMatricula registro= new VentanaMatricula();
            registro.ShowDialog();
        }
    }
}
