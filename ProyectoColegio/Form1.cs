using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq;


namespace ProyectoColegio
{
    public partial class Form1 : Form
    {
        public Form1()
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
            double sumaMonto = 0;

            foreach (DataGridViewRow row in dgvResultados.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    sumaMonto += double.Parse(row.Cells[4].Value.ToString());
                }
            }
            
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
            Application.Exit();
        }
    }
}
