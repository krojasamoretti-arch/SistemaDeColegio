using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoColegio
{
    public partial class VentanaUniforme : Form
    {
            string[] prendas = { "Camisa", "Pantalón", "Buzo", "Falda", "Casaca" };
            double[] precios = { 35.00, 50.00, 80.00, 45.00, 50.00 };

        public VentanaUniforme()
        {
            InitializeComponent();
        }

        string prenda()
        {
            return cbPrenda.Text;
        }

        string talla()
        {
            return cbTalla.Text;
        }

        double precio()
        {
            double precio = double.Parse(txtPrecio.Text);
            return precio;
        }

        double cantidad()
        {
            double cantidad = double.Parse(cbCantidad.Text);
            return cantidad;
        }

        double total()
        {
            double total = precio() * cantidad();
            return total;
        }

        void calcularTotales()
        {
            double sumaCantidad = 0;
            double sumaPrecioTotal = 0;

            foreach (DataGridViewRow row in dgvResultados.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    sumaCantidad += double.Parse(row.Cells[3].Value.ToString());
                }

                if (row.Cells[4].Value != null)
                {
                    sumaPrecioTotal += double.Parse(row.Cells[4].Value.ToString());
                }
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {

            dgvResultados.Rows.Add(
                prenda(),
                talla(),
                precio(),
                cantidad(),
                total()
                );




        }
        
        private void cbPrenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecio.Clear();

            for (int i=0; 1<prendas.Length; i++)
            {
                if (prendas[i] == cbPrenda.Text)
                {
                    txtPrecio.Text = precios[i].ToString("0.00");
                    break;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
