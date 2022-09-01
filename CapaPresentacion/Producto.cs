using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;

namespace CapaPresentacion
{
    public partial class Producto : Form
    {
        CNNatur cnNatur = new CNNatur();

        public Producto()
        {
            InitializeComponent();
        }

        private void insertarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlActualizar.Visible = false;
            pnlConsultar.Visible = false;
            pnlEliminar.Visible = false;
            pnlInsertarProducto.Visible = true;
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlActualizar.Visible = false;
            pnlConsultar.Visible = true;
            pnlEliminar.Visible = false;
            pnlInsertarProducto.Visible = false;
        }

        private void actualizarProdructoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlActualizar.Visible = true;
            pnlConsultar.Visible = false;
            pnlEliminar.Visible = false;
            pnlInsertarProducto.Visible = false;

        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlActualizar.Visible = false;
            pnlConsultar.Visible = false;
            pnlEliminar.Visible = true;
            pnlInsertarProducto.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado;
            CENatur producto = new CENatur();
            resultado = cnNatur.ValidarDatos(producto);
            producto.Codigo = int.Parse(txtCodigo.Text);
            producto.Descripcion = txtDescipcion.Text;
            producto.valor = double.Parse(txtValor.Text);
            producto.Nombre = txtNombrePro.Text;
            producto.cantidad = int.Parse(txtCantidad.Text);

            if (producto.Codigo > 0)
            {
                cnNatur.Insertar(producto);
                LimpiarForm();
            }
            else
            {
                MessageBox.Show("El campo codigo es invalido");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
        private void LimpiarForm()
        {
            txtCodigo.Text = string.Empty;
            txtNombrePro.Text = string.Empty;
            txtDescipcion.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtCantidad.Text = string.Empty;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var funciones = new CNNatur();
            txtActualizar.DataSource = funciones.ListarProductos();
            txtActualizar.DisplayMember = "proCodigo";
            //GridConsultar.Rows.Clear();

            var Tabla = cnNatur.Listar();
            GridConsultar.DataSource = Tabla;
            /*var NumeroFilas = Tabla.Rows.Count;
            if (NumeroFilas > 0)
            {
                for (int i = 0; i < NumeroFilas; i++)
                {
                    String Nombre = Tabla.Rows[i][1].ToString();
                    String Descipcion = Tabla.Rows[i][2].ToString();
                    String Valor = Tabla.Rows[i][3].ToString();
                    String Cantidad = Tabla.Rows[i][4].ToString();

                    GridConsultar.Rows.Add(Nombre, Descipcion, Valor, Cantidad);
                }

            }*/
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            var funciones = new CNNatur();
            txtActualizar.DataSource = funciones.ListarProductos();
            txtActualizar.DisplayMember = "proCodigo";

            txtEliminar.DataSource = funciones.ListarProductos();
            txtEliminar.DisplayMember = "proCodigo";


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var funciones = new CNNatur();
            if (txtEliminar.Text == "0") return;
            if (MessageBox.Show("¿Desea eliminar el registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CENatur producto = new CENatur();
                producto.Codigo = int.Parse(txtEliminar.Text);
                cnNatur.Deletear(producto);

                txtEliminar.DataSource = funciones.ListarProductos();
                txtEliminar.DisplayMember = "proCodigo";
            }
            txtEliminar.DataSource = funciones.ListarProductos();
            txtEliminar.DisplayMember = "proCodigo";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            MySqlDataReader reader = cnNatur.BuscarPorCodigo(int.Parse(txtActualizar.Text));
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtCodigoAc.Text = reader.GetString(0);
                    txtNombre.Text = reader.GetString(1);
                    txtDescAct.Text = reader.GetString(2);
                    txtValorAc.Text = reader.GetString(3);
                    txtCanAc.Text = reader.GetString(4);
                    var funciones = new CNNatur();
                    txtActualizar.DataSource = funciones.ListarProductos();
                    txtActualizar.DisplayMember = "proCodigo";
                }
            }
            else
            {
                MessageBox.Show("No se encontro el registro");
            }

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            CENatur producto = new CENatur();
            producto.Codigo = int.Parse(txtCodigoAc.Text);
            producto.Descripcion = txtDescAct.Text;
            producto.valor = double.Parse(txtValorAc.Text);
            producto.Nombre = txtNombre.Text;
            producto.cantidad = int.Parse(txtCanAc.Text);
            cnNatur.ActualizarDatos(producto);

            txtCodigoAc.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescAct.Text = string.Empty;
            txtValorAc.Text = string.Empty;
            txtCanAc.Text = string.Empty;
        }
    }
}
