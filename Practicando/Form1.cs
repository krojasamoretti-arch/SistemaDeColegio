namespace Practicando
{
    public partial class Form1 : Form
    {

        string ruta = "cursos.txt";
        public Form1()
        {
            InitializeComponent();
        }


        string Disponibilidad(double vacante)
        {
            if (vacante == 0)
            {
                return "Sin vacantes";
            }
            else if (vacante <= 5)
            {
                return "Pocas vacantes";
            }
            else
            {
                return "Disponible";
            }
        }

        void cargarDatos()
        {
            dgvDatos.Rows.Clear();

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);

                for (int i = 0; i < lineas.Length; i++)
                {
                    string[] datos = lineas[i].Split("|");
                    if (datos.Length >= 4)
                    {
                        double vacante = Convert.ToDouble(datos[4]);
                        string estado = Disponibilidad(vacante);
                        dgvDatos.Rows.Add(datos[0],
                                          datos[1],
                                          datos[2],
                                          datos[3],
                                          datos[4],
                                          estado);
                    }
                }
            }

        }

        private bool validarCampo()
        {
            string codigo = txtCodigo.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Ingrese un código");
                txtCodigo.Focus();
                return false;
            }
            
            if (txtCodigo.Text.Length > 4)
            {
                MessageBox.Show("Ingrese máximo 4 caracteres");
                return false;
            }

            
            return false;

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!validarCampo())
                return;
            
        }
    }
}
