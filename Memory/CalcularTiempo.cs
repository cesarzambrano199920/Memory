using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Memory
{
    class CalcularTiempo
    {
        //Guarda el tiempo en un archivo txt.
        public void Tiempo(string n)
        {
            try
            {    
                StreamWriter tiempo = new StreamWriter("Tiempo.txt");
                tiempo.Write(n);
                tiempo.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Guarda la cantidad de numeros en un archivo txt.
        public void Cantidad(string n)
        {
            try
            {
                StreamWriter cantidad = new StreamWriter("Cantidad.txt");
                cantidad.Write(n);
                cantidad.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Guarda el resultado
        public void Resultado(string r)
        {
            try
            {
                StreamWriter resultado = new StreamWriter("Resultado.txt");
                resultado.Write(r);
                resultado.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Validar solo numeros
        public void Validar(KeyPressEventArgs pe)
        {
            try
            {
                if (char.IsNumber(pe.KeyChar))
                {
                    pe.Handled = false;
                }
                else if (char.IsControl(pe.KeyChar))
                {
                    pe.Handled = false;
                }
                else
                {
                    pe.Handled = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }  
        }

        //Generar numeros
        public string Generar()
        {
            try
            {
                int a = Optener();
                string numero = "";
                Random rnd = new Random(DateTime.Now.Millisecond);
                for (int i = 0; i < a; i++)
                {
                    numero = numero + rnd.Next(0, 10).ToString();
                }
                return numero;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "";
            }

        }

        // Optiene la cantidad de numeros a generar
        public int Optener()
        {
            try
            {
                string a;
                StreamReader cantidad = new StreamReader("Cantidad.txt");
                a = cantidad.ReadToEnd().ToString();
                cantidad.Close();
                return Int32.Parse(a);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 0;
            }
        }
    }
}
