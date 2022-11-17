using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo.Clases
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private string numTarjeta;
        private string pin;
        private string saldo;


        public Usuario(string Nombre, string Apellido, string NumTarjeta, string Pin, string Saldo)
        {
            this.nombre = Nombre;
            this.apellido = Apellido;
            this.numTarjeta = NumTarjeta;
            this.pin = Pin;
            this.saldo = Saldo;
        }


        public void setNombre(String Nombre)
        {
            this.nombre = Nombre;
        }
        public String getNombre()
        {
            return this.nombre;
        }

        public void setApellido(String Apellido)
        {
            this.apellido = Apellido;
        }
        public String getApellido()
        {
            return this.apellido;
        }

        public void setNumTarjeta(String NumTarjeta)
        {
            this.numTarjeta = NumTarjeta;
        }
        public String getNumTarjeta()
        {
            return this.numTarjeta;
        }

        public void setPin(String Pin)
        {
            this.pin = Pin;
        }
        public String getPin()
        {
            return this.pin;
        }

        public void setSaldo(String saldo)
        {
            this.saldo = saldo;
        }

        public String getSaldo()
        {
            return this.saldo;
        }

    }
}
