using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Cliente : Form
    {
        CNNatur cnNatur = new CNNatur();
        public Cliente()
        {
            InitializeComponent();
        }
        private void LimpiarForm()
        {
            txtDocumento.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado;
            CENatur cliente = new CENatur();
            resultado = cnNatur.ValidarDatos(cliente);
            cliente.documento = int.Parse(txtDocumento.Text);
            cliente.nombreCliente = txtNombre.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.telefono = txtTelefono.Text;
            cliente.correo = txtCorreo.Text;

            if (cliente.documento > 0)
            {
                cnNatur.InsertarCliente(cliente);
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //GridConsultar.Rows.Clear();
            var Tabla = cnNatur.ListarCliente();
            GridConsultar.DataSource = Tabla;
        }

        private void brnBuscar_Click(object sender, EventArgs e)
        {
            MySqlDataReader reader = cnNatur.BuscarPorDocumento(int.Parse(txtActCliente.Text));
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    txtDocumentoAct.Text = reader.GetString(0);
                    txtNombreAct.Text = reader.GetString(1);
                    txtDireccionAct.Text = reader.GetString(2);
                    txtTelefonoAct.Text = reader.GetString(3);
                    txtCorreoAct.Text = reader.GetString(4);
                    var funciones = new CNNatur();
                    txtActCliente.DataSource = funciones.ListarCliente();
                    txtActCliente.DisplayMember = "clidocumento";
                }
            }
            else
            {
                MessageBox.Show("No se encontro el registro");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtEliminar.Text == "0") return;
            if (MessageBox.Show("¿Desea eliminar el registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CENatur cliente = new CENatur();
                cliente.documento = int.Parse(txtEliminar.Text);
                cnNatur.DeletearCliente(cliente);
                var funciones = new CNNatur();
                txtEliminar.DataSource = funciones.ListarCliente();
                txtEliminar.DisplayMember = "clidocumento";
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            var funciones = new CNNatur();
            txtActCliente.DataSource = funciones.ListarCliente();
            txtActCliente.DisplayMember = "clidocumento";

            txtEliminar.DataSource = funciones.ListarCliente();
            txtEliminar.DisplayMember = "clidocumento";
        }

        private void btnGuardarAct_Click(object sender, EventArgs e)
        {
            var funciones = new CNNatur();
            txtActCliente.DataSource = funciones.ListarCliente();
            txtActCliente.DisplayMember = "clidocumento";
            
            CENatur cliente = new CENatur();
            cliente.documento = int.Parse(txtDocumentoAct.Text);
            cliente.nombreCliente = txtNombreAct.Text;
            cliente.direccion = txtDireccionAct.Text;
            cliente.telefono = txtTelefonoAct.Text;
            cliente.correo = txtCorreoAct.Text;
            cnNatur.ActualizarDatosCliente(cliente);

            txtDocumentoAct.Text = string.Empty;
            txtNombreAct.Text = string.Empty;
            txtDireccionAct.Text = string.Empty;
            txtTelefonoAct.Text = string.Empty;
            txtCorreoAct.Text = string.Empty;
        }
    }
}
