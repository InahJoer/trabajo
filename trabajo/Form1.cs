using System.Text.Json;
using trabajo.Clases;

namespace trabajo
{
    public partial class BANCO : MaterialSkin.Controls.MaterialForm
    {

        List<Usuario> listUsuarios = new List<Usuario>();

        public BANCO()
        {
            InitializeComponent();
            listUsuarios.Add(new Usuario("Marvin", "Moran", "123456", "7830", "15000"));
            listUsuarios.Add(new Usuario("Efrain", "Canastuj", "333333", "2222", "20000"));
            listUsuarios.Add(new Usuario("William", "Yuman", "444444", "0000", "30000"));
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            lblMensaje.Visible = true;
            Boolean login = false;
            if (this.txtNumero.Text.Length <= 0)
            {

                this.lblMensaje.Text = "Ingrese No. de Tarjeta";
                login = false;
            }
            else
            {

                foreach (Usuario result in listUsuarios)
                {
                    if (result.getNumTarjeta().Equals(this.txtNumero.Text.Trim()))
                    {
                        string path = "C:\\Users\\gonae\\OneDrive\\Documentos\\cuentas\\Saldo.txt";
                        string path2 = "C:\\Users\\gonae\\OneDrive\\Documentos\\cuentas\\users.txt";
                        frmCajero formPin = new frmCajero(result.getNumTarjeta(), result.getPin(), result.getNombre(), result.getApellido(), result.getSaldo());
                        string texto = result.getNombre() + ";" + result.getSaldo();
                        string texto2 = "Nombre: " + result.getNombre() + " Apellido: " + result.getApellido() + " N° Tarjeta: " + result.getNumTarjeta().Encriptar() + " Pin: " + result.getPin().Encriptar() + " Saldo: " + result.getSaldo();
                        using (StreamWriter writer = new StreamWriter(path))
                        {
                            writer.WriteLine(texto);
                        }
                        using (StreamWriter writer = new StreamWriter(path2))
                        {
                            writer.WriteLine(texto2);
                             
                        }
                        this.Hide();
                        formPin.ShowDialog();
                        this.Close();
                    }
                }
                if (login == false)
                {
                    this.lblMensaje.Text = "No tarjeta No Existe";
                }
            }
        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}