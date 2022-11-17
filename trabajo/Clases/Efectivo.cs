using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo.Clases
{
    class Efectivo
    {
        private String archivoEfectivo;
        private String efectivoStr;

        public Efectivo()
        {
            this.archivoEfectivo = @"C:\Users\gonae\OneDrive\Documentos\cuentas\Efectivo.txt";
            efectivoStr = "";
        }

        public double MuestraEfectivo()
        {
            try
            {
                {
                    using (StreamReader sr = new StreamReader(archivoEfectivo))
                    {
                        while (sr.Peek() >= 0)
                        {
                            string s = sr.ReadLine();
                            string[] split = s.Split(';');
                            efectivoStr = split[0];
                        }
                    }
                }
            }
            catch (Exception x)
            {
                Console.WriteLine("Falló: {0}", x.ToString());
            }
            return double.Parse(efectivoStr);
        }

        public string EfectivoMostrar()
        {
            return efectivoStr;
        }

        public void ActualizaEfectivo(double debito)
        {
            double doubleEfectivo = double.Parse(efectivoStr);
            doubleEfectivo = doubleEfectivo - debito;
            string text = File.ReadAllText(archivoEfectivo);
            text = text.Replace(efectivoStr, doubleEfectivo.ToString());
            File.WriteAllText(archivoEfectivo, text);
        }
    }
}
