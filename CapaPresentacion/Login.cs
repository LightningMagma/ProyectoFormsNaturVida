using CapaNegocio;
using CapaEntidad;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Memcached;

namespace CapaPresentacion
{
    public partial class login : Form
    {
        CNNatur nNatur = new CNNatur();
        string user = "";
        string pass = "";
        public login()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {            
            CENatur cENatur = new CENatur();

            cENatur.usuario = txtUsuarios.Text;
            cENatur.contrase�a = txtContrase�as.Text;
            CENatur reader = nNatur.ExisteUsuario(cENatur);

            if (reader.usuario == txtUsuarios.Text && reader.contrase�a  == txtContrase�as.Text)
            {
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrecta");
            }



            /*if (txtUsuarios.Text == user && txtContrase�as.Text == pass)
            {
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrecta");
            }*/
        }

        private void Prueba_Click(object sender, EventArgs e)
        {
            nNatur.PruebaMySQL();
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }
    }
}