using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoColegio
{
    public partial class VentanaLibros : Form
    {


        string[] libros = { "Matemáticas", "Comunicación", "Ciencias", "Historia", "Biología" };
        double[] precios = { 50.00, 50.00, 35.00, 35.00, 35.00 };
        public VentanaLibros()
        {
            InitializeComponent();
        }

        string libro()
        {
            return cbLibro.Text;
        }

        double precio()
        {
            double precio = double.Parse(txtPrecio.Text);
            return precio;
        }

        double canidad()
        {
            double cantidad = double.Parse(cbCantidad.Text);
            return cantidad;
        }

        double total()
        {
            double total = precio() * canidad();
            return total;
        }


        private void btnRegistrarLibro_Click(object sender, EventArgs e)
        {
            dgvResultados.Rows.Add(
               libro(),
               precio(),
               canidad(),
               total());
        }

        private void cbLibro_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtPrecio.Clear();

            for (int i=0; 1<libros.Length; i++)
            {
                if (libros[i] == cbLibro.Text)
                {
                    txtPrecio.Text = precios[i].ToString("0.00");
                    break;
                }
            }
        }
    }


}
