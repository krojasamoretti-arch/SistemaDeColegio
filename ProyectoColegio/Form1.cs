using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            txtMonto.Text = sumaMonto.ToString("0.00");
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
            dgvResultados.Rows.Add(
                nombre(),
                dni(),
                grado(),
                apoderado(),
                monto());

            CalcularMatricula();
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
