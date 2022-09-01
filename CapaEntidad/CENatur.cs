
namespace CapaEntidad
{
    public class CENatur
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public double valor { get; set; }
        public double cantidad { get; set; }


        public int facNumero { get; set; }
        public string facFecha { get; set; }
        public int facCliente { get; set; }
        public double facValorTotal { get; set; }
        public int facVen { get; set; }
        public int Facturadetalle { get; set; }
        public int documento { get; set; }
        public string nombreCliente { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }
        public CENatur()
        {

        }
    }
}