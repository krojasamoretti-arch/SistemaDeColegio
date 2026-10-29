namespace ProyectoColegio
{
    public partial class VentanaMatricula : Form
    {


        string[] grados = { "Primero (Primaria)", "Segundo (Primaria)",
            "Tercero (Primaria)","Cuarto (Primaria)","Quinto (Primaria)","Sexto (Primaria)",
             "Primero (Secundiaria)","Segundo (Secundaria)","Tercero (Secundaria)",
            "Cuarto (Secundaria)","Quinto (Secundaria)"};

        double[] precios = { 250.00, 350.00 };

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

        private bool ValidarCamposMatricula()
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



        void CalcularMatricula()
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


            CalcularMatricula();

            if (!ValidarCamposMatricula())
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
            for (int i = 0; i < grados.Length; i++)
            {
                double precio;

                if (grados[i].Contains("Primaria"))
                {
                    precio = precios[0];
                }
                else
                {
                    precio = precios[1];
                }

                txtMonto.Text = Convert.ToString(precio);
            }


        }
    }
}
