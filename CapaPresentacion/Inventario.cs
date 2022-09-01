using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmInventario : Form
    {
        CNNatur cnNatur = new CNNatur();
        public frmInventario()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //GridInventario.Rows.Clear();

            var Tabla = cnNatur.Listar();            
            GridInventario.DataSource=Tabla;
            
            /*if (NumeroFilas > 0)
            {
                for (int i = 0; i < NumeroFilas; i++)
                {
                    String Nombre = Tabla.Rows[i][1].ToString();
                    String Descipcion = Tabla.Rows[i][2].ToString();
                    String Valor = Tabla.Rows[i][3].ToString();
                    String Cantidad = Tabla.Rows[i][4].ToString();

                    GridInventario.Rows.Add(Nombre, Descipcion, Valor, Cantidad);
                }

            }*/

        }
    }
}
