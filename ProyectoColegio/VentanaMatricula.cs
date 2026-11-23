namespace ProyectoColegio
{
    public partial class VentanaMatricula : Form
    {
        double[] precios = { 250, 350 };

        public VentanaMatricula()
        {
            InitializeComponent();
        }

        string nombre()
        {
            return txtNombre.Text;
        }

        string dni()
        {
            return txtDni.Text;
        }

        string apoderado()
        {
            return txtApoderado.Text;
        }

        string grado()
        {
            return cbGrado.Text;
        }

        double monto()
        {
            double monto = double.Parse(txtMonto.Text);
            return monto;
        }

        private bool ValidarCampos()
        {
            string dni = txtDni.Text.Trim();

            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("El DNI es obligatorio.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                return false;
            }

            if (dni.Length != 8 || !dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe tener 8 dígitos numéricos.", "DNI inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDni.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre completo es obligatorio.", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            return true;
        }



        void CalcularTotal()
        {
            double sumaMonto = Convert.ToDouble(txtMonto.Text);

            foreach (DataGridViewRow row in dgvResultados.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    sumaMonto += double.Parse(row.Cells[4].Value.ToString());
                }
            }

            txtTotal.Text = Convert.ToString(sumaMonto);
        }

        void Limpiar()
        {
            txtApoderado.Clear();
            txtDni.Clear();
            txtMonto.Clear();
            txtNombre.Clear();

            txtNombre.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {


            CalcularTotal();

            if (!ValidarCampos())
                return;

            dgvResultados.Rows.Add(
                nombre(),
                dni(),
                grado(),
                apoderado(),
                monto());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            double precio;

            if (cbGrado.SelectedIndex >= 0 && cbGrado.SelectedIndex <= 5)
            {
                precio = precios[0];
            }
            else
            {
                precio = precios[1];
            }


            txtMonto.Text = Convert.ToString(precio);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

      
