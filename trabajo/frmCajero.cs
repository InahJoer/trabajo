using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabajo.Clases;

namespace trabajo
{
    public partial class frmCajero : MaterialSkin.Controls.MaterialForm
    {
        List<Usuario> listUsuarios = new List<Usuario>();
        private String NumTarjeta;
        private String NumPin;
        private String Nombre;
        private String Apellido;
        public frmCajero(string numTarjeta, string numPin, string nombre, string apellido, string saldo)
        {
            this.NumTarjeta = numTarjeta;
            this.NumPin = numPin;
            this.Nombre = nombre;
            this.Apellido = apellido;
            listUsuarios.Add(new Usuario("Marvin", "Moran", "123456", "7830", "15000"));
            listUsuarios.Add(new Usuario("Efrain", "Canastuj", "333333", "2222", "20000"));
            listUsuarios.Add(new Usuario("William", "Yuman", "444444", "0000", "30000"));
            InitializeComponent();
        }

        private void frmCajero_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Boolean login = false;
            if (this.txtPin.Text.Length <= 0)
            {
                this.lblMensajePin.Text = "Ingrese No. de Pin";
                login = false;
            }
            else
            {

                foreach (Usuario result in listUsuarios)
                {
                    if (result.getPin().Equals(this.txtPin.Text.Trim()))
                    {
                        frmAtm formCaje = new frmAtm(result.getNumTarjeta(), result.getPin(), result.getNombre(), result.getApellido());
                        this.Hide();
                        formCaje.ShowDialog();
                        this.Close();
                    }
                }
                if (login == false)
                {
                    this.lblMensajePin.Text = "No Existe ese Pin";
                }
            }

        }
    }
}
