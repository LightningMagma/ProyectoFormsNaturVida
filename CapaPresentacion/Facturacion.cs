using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaPresentacion
{
    public partial class Facturacion : Form
    {
        CNNatur CNNatur = new CNNatur();
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {           
            txtCliente.DataSource = CNNatur.ListarClientes();
            txtCliente.DisplayMember = "cliDocumento";
            txtProducto.DataSource = CNNatur.ListarProductos();
            txtProducto.DisplayMember = "proCodigo";

        }

        private void btnTerminarFactura_Click(object sender, EventArgs e)
        {
            CENatur cENatur = new CENatur();
            cENatur.facNumero = int.Parse(txtCodigo.Text);   
            
            MySqlDataReader reader = CNNatur.TerminarFactura(int.Parse(txtCodigo.Text));
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                    txtTotalFactura.Text = reader.GetString(0);
                    cENatur.facValorTotal = int.Parse(txtTotalFactura.Text);
                }
            }
            else
            {
                MessageBox.Show("No se encontro el registro");
            }
            CNNatur.GuardarFacturaMiauMiau(cENatur);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            CENatur produto = new CENatur();
            DataTable codigoFactura = CNNatur.BuscarCodigoFactura();
            produto.facNumero = int.Parse(txtCodigo.Text);

            string cadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;database=naturvida";
            using (MySqlConnection cn = new MySqlConnection(cadenaConexion))
            {
                var cmd = new MySqlCommand("SELECT COUNT(*) FROM facturas WHERE facNumero= @facNumero", cn);
                cmd.Parameters.AddWithValue("@facNumero", txtCodigo.Text);
                cn.Open();
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
                {
                    //Insertar fila
                    produto.facNumero = int.Parse(txtCodigo.Text);
                    produto.facFecha = txtFecha.Text;
                    produto.facCliente = int.Parse(txtCliente.Text);
                    CNNatur.GenerarFactura(produto);
                    produto.Codigo = int.Parse(txtProducto.Text);
                    produto.cantidad = int.Parse(txtCantidad.Text);
                    CNNatur.AgregarPrimerProducto(produto);
                }
                else
                {
                    //El valor ya existe en la tabla
                    produto.Codigo = int.Parse(txtProducto.Text);
                    produto.cantidad = int.Parse(txtCantidad.Text);
                    CNNatur.AgregarProducto(produto);
                    GridFactura.Rows.Clear();
                    ListarProductos();
                }
            }         
            //CNNatur.ActualizarFactura(produto);


        }
        private void ListarProductos()
        {
            CENatur cENatur = new CENatur();
            cENatur.Codigo = int.Parse(txtCodigo.Text);
            var Tabla = CNNatur.ListarFactura(cENatur.Codigo);
            var numeroFilas = Tabla.Rows.Count;
            if (numeroFilas > 0)
            {

                for (int i = 0; i < numeroFilas; i++)
                {
                    string iD = Tabla.Rows[i][0].ToString();
                    string facNumero = Tabla.Rows[i][1].ToString();
                    string facProducto = Tabla.Rows[i][2].ToString();
                    string cantidaPro = Tabla.Rows[i][3].ToString();
                    GridFactura.Rows.Add(iD, facNumero, facProducto, cantidaPro);
                }
            }

            else
            {
                MessageBox.Show("No se encontro el registro");
            }
        }

        private void btnActualizarfactura_Click(object sender, EventArgs e)
        {
            GridFactura.Rows.Clear();
            CENatur cENatur = new CENatur();
            cENatur.facNumero = int.Parse(txtCodigo.Text);
            var Tabla = CNNatur.ListarFactura(cENatur.facNumero);
            var numeroFilas = Tabla.Rows.Count;
            if (numeroFilas > 0)
            {

                for (int i = 0; i < numeroFilas; i++)
                {
                    string iD = Tabla.Rows[i][0].ToString();
                    string facNumero = Tabla.Rows[i][1].ToString();
                    string facProducto = Tabla.Rows[i][2].ToString();
                    string cantidaPro = Tabla.Rows[i][3].ToString();
                    string proValor = Tabla.Rows[i][4].ToString();
                    GridFactura.Rows.Add(iD, facNumero, facProducto, cantidaPro,proValor);
                }
            }
            else
            {
                MessageBox.Show("No se encontro el registro");
            }
        }
        public bool Validar(CENatur cENatur)
        {
            bool resultado = true;
            if (cENatur.facNumero==int.Parse(txtCodigo.Text))
            {
                resultado = false;
            }
            return resultado;
        }
        
       
    }
}
