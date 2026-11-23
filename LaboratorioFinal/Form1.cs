namespace LaboratorioFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void Limpiar()
        {
            txtCliente.Clear();
            txtMonto.Clear();
            txtTelefono.Clear();

            txtCliente.Focus();

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        void Salir()
        {
            DialogResult resultado = MessageBox.Show("Salir del programa?",
                            "SALIR",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }


        string Cliente()
        {
            return txtCliente.Text;
        }

        string Telefono()
        {
            return txtTelefono.Text;
        }

        string Paquete()
        {
            if (cbPaquete.SelectedIndex == 0)
            {
                return "Video Normal";
            }
            else
            {
                return "Video editado";
            }
        }

        string Monto()
        {
            return txtMonto.Text;
        }

        string Metodo()
        {
            if (cbPaquete.SelectedIndex == 0)
            {
                return "Efectivo";
            }
            else
            {
                return "Yape / Plin";
            }
        }

        string Trabajador()
        {
            if (cbTrabajador.SelectedIndex == 0)
            {
                return "Luigino Vizacarra";
            }
            else if (cbTrabajador.SelectedIndex == 1)
            {
                return "Milagros Morales";
            }
            else
            {
                return "Pablo Reyes";
            }
        }

        private bool ValidarCampos()
        {
            string cliente = txtCliente.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (string.IsNullOrWhiteSpace(cliente))
            {
                MessageBox.Show("El nombre es obligatorio.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCliente.Focus();
                return false;
            }

            if (telefono.Length != 9 || !telefono.All(char.IsDigit))
            {
                MessageBox.Show("El numero telefonico debe tener 9 dígitos.", "Número inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("El monto es obligatorio.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return false;
            }
            return true;
        }

        void verResumen()
        {
            double sumaMonto = 0.0;
            int totalVideos = 0;

            foreach (DataGridViewRow row in dgvResultados.Rows)
            {
                if (!row.IsNewRow && row.Cells[3].Value != null)
                {
                    sumaMonto += Convert.ToDouble(row.Cells[3].Value);
                    totalVideos++;
                }
            }

            MessageBox.Show("=== RESUMEN DE CAJA ===\n" +
                            "Total de servicios: " + totalVideos + "\n" +
                            "Monto total recaudado: S/ " + sumaMonto.ToString("N2"),
                            "Cierre de Caja",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            dgvResultados.Rows.Add(Cliente(),
                                   Telefono(),
                                   Paquete(),
                                   Monto(),
                                   Metodo(),
                                   Trabajador());


        }

        private void button1_Click(object sender, EventArgs e)
        {
            verResumen();
        }
    }
}
