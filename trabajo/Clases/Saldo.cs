using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo.Clases
{
    class Saldo
    {

        private String cuenta;
        private String saldo;
        private String ArchivoSaldo;
        public Saldo(string archivoSaldo)
        {
            this.ArchivoSaldo = @"C:\Users\gonae\OneDrive\Documentos\cuentas\Saldo.txt";
            regresaSaldo();
        }

        public void regresaSaldo()
        {
            try
            {
                if (File.Exists(ArchivoSaldo))
                {
                    using (StreamReader sr = new StreamReader(ArchivoSaldo))
                    {
                        while (sr.Peek() >= 0)
                        {

                            string s = sr.ReadLine();
                            string[] split = s.Split(';');
                            cuenta = split[0];
                            saldo = split[1];
                            Console.WriteLine("Saldo xxx " + cuenta + " " + saldo);
                        }

                    }
                }

            }
            catch (Exception x)
            {
                Console.WriteLine("Falló: {0}", x.ToString());
            }

        }

        public void ActualizaSaldo(double xDebito)
        {
            double doubleSaldo = double.Parse(saldo);
            doubleSaldo = doubleSaldo - xDebito;
            string text = File.ReadAllText(ArchivoSaldo);
            text = text.Replace(saldo, doubleSaldo.ToString());
            File.WriteAllText(ArchivoSaldo, text);
        }
        public void SumarSaldo(double xDebito)
        {
            double doubleSaldo = double.Parse(saldo);
            doubleSaldo = doubleSaldo + xDebito;
            string text = File.ReadAllText(ArchivoSaldo);
            text = text.Replace(saldo, doubleSaldo.ToString());
            File.WriteAllText(ArchivoSaldo, text);
        }
        public void setCuenta(string Cuenta)
        {
            this.cuenta = Cuenta;
        }

        public string getCuenta()
        {
            return this.cuenta;
        }

        public void setSaldo(string Saldo)
        {
            this.saldo = Saldo;
        }
        public string getSaldo()
        {
            return this.saldo;
        }


    }
}
