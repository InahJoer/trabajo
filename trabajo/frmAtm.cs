using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabajo.Clases;

namespace trabajo
{
    public partial class frmAtm : MaterialSkin.Controls.MaterialForm
    {
        private string Apellido;
        private string Nombre;
        private string NumPin;
        private string NumTarjeta;
        private string archivoSaldo;
        private string cuenta;
        private string saldo;
        public frmAtm(string numTarjeta, string numPin, string nombre, string apellido)
        {
            this.NumTarjeta = numTarjeta;
            this.NumPin = numPin;
            this.Nombre = nombre;
            this.Apellido = apellido;
            InitializeComponent();
            this.lblNombre.Text = "Bienvenido " + nombre + " " + apellido;
            this.archivoSaldo = @"C:\Users\gonae\OneDrive\Documentos\cuentas" + NumTarjeta + ".txt";
            this.cuenta = "";
            this.saldo = "";
            Saldo xsaldo = new Saldo(archivoSaldo);
            cuenta = xsaldo.getSaldo();
            saldo = xsaldo.getSaldo();
            Console.WriteLine("Saldo " + cuenta + " " + saldo);
        }

        private void frmAtm_Load(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Saldo xSaldo = new Saldo(archivoSaldo);
            lblSaldo.Text = "C$. " + xSaldo.getSaldo();
        }

        private void RetirarCincuenta_Click(object sender, EventArgs e)
        {
            this.lblMensaje.Text = " ";
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 50.00)
            {
                Retiro(50.00);
                efec.ActualizaEfectivo(50.00);


            }
            else
            {
                this.lblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                lblMensaje.ForeColor = Color.Red;
            }
            Saldo xSaldo = new Saldo(archivoSaldo);
            lblSaldo.Text = "C$. " + xSaldo.getSaldo();
            lblEfectivo.Text = "C$ " + efec.MuestraEfectivo();
            DialogResult salir = MessageBox.Show("Transaccion Realizada", "BANCO 18-23",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.None);
        }
        private void Retiro(double cantidad)
        {
            Saldo xSaldo = new Saldo(archivoSaldo);
            double doubleSaldo = double.Parse(xSaldo.getSaldo());
            if (doubleSaldo >= cantidad)
            {
                xSaldo.ActualizaSaldo(cantidad);
                this.lblMensaje.Text = "Se han retirado C$ " + cantidad.ToString();
                lblMensaje.ForeColor = Color.Blue;

            }
            else
            {
                this.lblMensaje.Text = "No tiene suficiente Saldo para hacer la Transaccion";
                lblMensaje.ForeColor = Color.Red;
            }
        }

        private void RetirarCien_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 100.00)
            {
                Retiro(100.00);
                efec.ActualizaEfectivo(100.00);

            }
            else
            {
                this.lblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                lblNombre.ForeColor = Color.Red;
            }
            Saldo xSaldo = new Saldo(archivoSaldo);
            lblSaldo.Text = "C$. " + xSaldo.getSaldo();
            lblEfectivo.Text = "C$ " + efec.MuestraEfectivo();
            DialogResult salir = MessageBox.Show("Transaccion Realizada", "BANCO 18-23",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
        }

        private void RetirarDoscientos_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 200.00)
            {
                Retiro(200.00);
                efec.ActualizaEfectivo(200.00);
                
            }
            else
            {
                this.lblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                lblMensaje.ForeColor = Color.Red;
            }
            Saldo xSaldo = new Saldo(archivoSaldo);
            lblSaldo.Text = "C$. " + xSaldo.getSaldo();
            lblEfectivo.Text = "C$ " + efec.MuestraEfectivo();
            DialogResult salir = MessageBox.Show("Transaccion Realizada", "BANCO 18-23",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
        }

        private void RetirarDoscientosCin_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 250.00)
            {
                Retiro(250.00);
                efec.ActualizaEfectivo(250.00);
                lblEfectivo.Text = "C$ " + efec.MuestraEfectivo();
            }
            else
            {
                this.lblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                lblMensaje.ForeColor = Color.Red;
            }
            Saldo xSaldo = new Saldo(archivoSaldo);
            lblSaldo.Text = "C$. " + xSaldo.getSaldo();
            lblEfectivo.Text = "C$ " + efec.MuestraEfectivo();
            DialogResult salir = MessageBox.Show("Transaccion Realizada", "BANCO 18-23",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
        }

        private void RetirarQuinientos_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 500.00)
            {
                Retiro(500.00);
                efec.ActualizaEfectivo(500.00);
                lblEfectivo.Text = "C$ " + efec.MuestraEfectivo();
            }
            else
            {
                this.lblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                lblMensaje.ForeColor = Color.Red;
            }
            Saldo xSaldo = new Saldo(archivoSaldo);
            lblSaldo.Text = "C$. " + xSaldo.getSaldo();
            lblEfectivo.Text = "C$ " + efec.MuestraEfectivo();
            DialogResult salir = MessageBox.Show("Transaccion Realizada", "BANCO 18-23",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
        }

        private void btnTrescientos_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 300.00)
            {
                Retiro(300.00);
                efec.ActualizaEfectivo(300.00);
                lblEfectivo.Text = "C$ " + efec.MuestraEfectivo();
            }
            else
            {
                this.lblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                lblMensaje.ForeColor = Color.Red;
            }
            Saldo xSaldo = new Saldo(archivoSaldo);
            lblSaldo.Text = "C$. " + xSaldo.getSaldo();
            lblEfectivo.Text = "C$ " + efec.MuestraEfectivo();
            DialogResult salir = MessageBox.Show("Transaccion Realizada", "BANCO 18-23",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
        }

        private void RetirarMil_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 1000.00)
            {
                Retiro(1000.00);
                efec.ActualizaEfectivo(1000.00);
                lblEfectivo.Text = "C$ " + efec.MuestraEfectivo();
            }
            else
            {
                this.lblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                lblMensaje.ForeColor = Color.Red;
            }
            Saldo xSaldo = new Saldo(archivoSaldo);
            lblSaldo.Text = "C$. " + xSaldo.getSaldo();
            lblEfectivo.Text = "C$ " + efec.MuestraEfectivo();
            DialogResult salir = MessageBox.Show("Transaccion Realizada", "BANCO 18-23",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);
        }

        private void RetirarDosMil_Click(object sender, EventArgs e)
        {
            Efectivo efec = new Efectivo();
            if (efec.MuestraEfectivo() >= 2000.00)
            {
                Retiro(2000.00);
                efec.ActualizaEfectivo(2000.00);

            
            }
            else
            {
                this.lblMensaje.Text = "Cajero no Tiene Efectivo para hacer la Transaccion";
                lblMensaje.ForeColor = Color.Red;
            }
            Saldo xSaldo = new Saldo(archivoSaldo);
            lblSaldo.Text = "C$. " + xSaldo.getSaldo();
            lblEfectivo.Text = "C$ " + efec.MuestraEfectivo();
            DialogResult salir = MessageBox.Show("Transaccion Realizada", "BANCO 18-23",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None);

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            Efectivo efect = new Efectivo();
            lblEfectivo.Text = "C$ " + efect.MuestraEfectivo();
        }

        private void materialFlatButton2_Click_1(object sender, EventArgs e)
        {
            double newsaldo = double.Parse(txtNewSaldo.Text);
            string archivo = "C:\\Users\\gonae\\OneDrive\\Documentos\\cuentas\\Saldo.txt";
            Saldo sal = new Saldo(archivo);
            sal.SumarSaldo(newsaldo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Amigo, vas a salir, estas seguro de ello?", "componentes",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (salir == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
