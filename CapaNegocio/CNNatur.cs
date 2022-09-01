using CapaDatos;
using CapaEntidad;
using MySql.Data.MySqlClient;
using System.Data;

namespace CapaNegocio
{
    public class CNNatur
    {
        CDNatur cDNatur = new CDNatur();
        CENatur cENatur = new CENatur();
        public bool ValidarDatos(CENatur producto)
        {
            bool resultado = true;
            if (producto.Nombre == string.Empty)
            {
                MessageBox.Show("Campo nombre esta vacio");
            }
            if (producto.Descripcion == string.Empty)
            {
                MessageBox.Show("Campo descripcion esta vacio");
            }
            if (producto.valor < 0)
            {
                MessageBox.Show("Campo valor es invalido");
            }
            if (producto.cantidad < 0)
            {
                MessageBox.Show("Campo cantidad es invalido");
            }
            if (producto.Codigo < 0)
            {
                MessageBox.Show("Campo Codigo es invalido");
            }
            return resultado;
        }
        public void PruebaMySQL()
        {
            cDNatur.pruebaConexion();
        }
        public void Insertar(CENatur cENatur)
        {
            cDNatur.Registrar(cENatur);
        }
        public DataTable Listar()
        {
            return cDNatur.Listar();
        }
        public DataTable ListarProductos()
        {
            return cDNatur.ListarProductos();
        }
        public void Deletear(CENatur cENatur)
        {
            cDNatur.Deletear(cENatur);
        }
        public MySqlDataReader BuscarPorCodigo(int cENatur)
        {
            return cDNatur.BuscarPorCodigo(cENatur);
        }
        public void ActualizarDatos(CENatur cENatur)
        {
            cDNatur.Actualizar(cENatur);
        }
        public DataTable ListarClientes()
        {
            return cDNatur.ListarClientes();
        }
        public void Facturar(CENatur cENatur)
        {
            cDNatur.Facturar(cENatur);
        }
        public void AgregarProducto(CENatur cENatur)
        {
            cDNatur.AgregarProductoFactura(cENatur);
        }
        public DataTable ListarFactura(int cENatur)
        {
            return cDNatur.ListarFactura(cENatur);
        }
        public DataTable BuscarCodigoFactura()
        {
            return cDNatur.BuscarPorCodigoFactura();
        }
        public void GenerarFactura(CENatur cENatur)
        {
            cDNatur.GenerarFactura(cENatur);
        }
        public void ActualizarFactura(CENatur cENatur)
        {
            cDNatur.ActualizarFactura(cENatur);
        }
        public void AgregarPrimerProducto(CENatur cENatur)
        {
            cDNatur.GenerarPrimerProducto(cENatur);
        }
        public MySqlDataReader TerminarFactura(int ceNatur)
        {
            return cDNatur.TerminarFactura(ceNatur);
        }
        public void GuardarFacturaMiauMiau(CENatur cENatur)
        {
            cDNatur.GuardarFactura(cENatur);
        }
        public void InsertarCliente(CENatur cENatur)
        {
            cDNatur.RegistrarCliente(cENatur);
        }
        public DataTable ListarCliente()
        {
            return cDNatur.ListarCliente();
        }
        public void DeletearCliente(CENatur cENatur)
        {
            cDNatur.DeletearCliente(cENatur);

        }
        public MySqlDataReader BuscarPorDocumento(int cENatur)
        {
            return cDNatur.BuscarPorDocumento(cENatur);
        }
        public void ActualizarDatosCliente(CENatur cENatur)
        {
            cDNatur.ActualizarCliente(cENatur);
        }
        public MySqlDataReader IniciarSesion(CENatur cENatur)
        {
            return cDNatur.IniciarSesion(cENatur);
        }
        public CENatur ExisteUsuario(CENatur cENatur)
        {
            return cDNatur.existeUsuario(cENatur);
        }

    }
}