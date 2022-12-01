using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Timers;

namespace Memory
{
    public partial class Principal : Form
    {
        private int contador;
        private int contador2;
        public Principal()
        {
            InitializeComponent();
            FileStream archivoT = new FileStream("Tiempo.txt", FileMode.Append, FileAccess.Write);
            FileStream archivoC = new FileStream("Cantidad.txt", FileMode.Append, FileAccess.Write);
            FileStream archivoR = new FileStream("Resultado.txt", FileMode.Append, FileAccess.Write);
            archivoT.Close();
            archivoC.Close();
            archivoR.Close();
            contador = 30;
        }

        CalcularTiempo calcular = new CalcularTiempo();
        
        //Botones de tiempo
        private void btn5_Click(object sender, EventArgs e)
        {
            calcular.Tiempo("5");
            CambiarColor(5);
            txtTiempoPR.Clear();
        }
        private void btn10_Click(object sender, EventArgs e)
        {
            calcular.Tiempo("10");
            CambiarColor(10);
            txtTiempoPR.Clear();
        }
        private void btn15_Click(object sender, EventArgs e)
        {
            calcular.Tiempo("15");
            CambiarColor(15);
            txtTiempoPR.Clear();
        }
        private void btn20_Click(object sender, EventArgs e)
        {
            calcular.Tiempo("20");
            CambiarColor(20);
            txtTiempoPR.Clear();
        }
        private void btn25_Click(object sender, EventArgs e)
        {
            calcular.Tiempo("25");
            CambiarColor(25);
            txtTiempoPR.Clear();
        }
        private void btn30_Click(object sender, EventArgs e)
        {
            calcular.Tiempo("30");
            CambiarColor(30);
            txtTiempoPR.Clear();
        }
        private void btnMinutos_Click(object sender, EventArgs e)
        {
            if (txtTiempoPR.Text != "")
            {
                calcular.Tiempo(txtTiempoPR.Text);
                CambiarColor(1);
            }
        }
        private void btnHoras_Click(object sender, EventArgs e)
        {
            if (txtTiempoPR.Text != "")
            {
                calcular.Tiempo((Int32.Parse(txtTiempoPR.Text) * 60).ToString());
                CambiarColor(2);
            }
        }

        //Botones de Cantidad
        private void btn5N_Click(object sender, EventArgs e)
        {
            calcular.Cantidad("5");
            CambiarColor2(5);
            txtCantidadDN.Clear();
        }
        private void btn10N_Click(object sender, EventArgs e)
        {
            calcular.Cantidad("10");
            CambiarColor2(10);
            txtCantidadDN.Clear();
        }
        private void btn15N_Click(object sender, EventArgs e)
        {
            calcular.Cantidad("15");
            CambiarColor2(15);
            txtCantidadDN.Clear();
        }
        private void btn20N_Click(object sender, EventArgs e)
        {
            calcular.Cantidad("20");
            CambiarColor2(20);
            txtCantidadDN.Clear();
        }

        //Cambiar color
        public void CambiarColor(byte a)
        {
            btn5.BackColor = Color.SlateGray;
            btn10.BackColor = Color.SlateGray;
            btn15.BackColor = Color.SlateGray;
            btn20.BackColor = Color.SlateGray;
            btn25.BackColor = Color.SlateGray;
            btn30.BackColor = Color.SlateGray;
            btnMinutos.BackColor = Color.SlateGray;
            btnHoras.BackColor = Color.SlateGray;
            switch(a)
            {
                case 5:
                    btn5.BackColor = Color.Coral;
                    break;
                case 10:
                    btn10.BackColor = Color.Coral;
                    break;
                case 15:
                    btn15.BackColor = Color.Coral;
                    break;
                case 20:
                    btn20.BackColor = Color.Coral;
                    break;
                case 25:
                    btn25.BackColor = Color.Coral;
                    break;
                case 30:
                    btn30.BackColor = Color.Coral;
                    break;
                case 1:
                    btnMinutos.BackColor = Color.Coral;
                    break;
                case 2:
                    btnHoras.BackColor = Color.Coral;
                    break;
            }
        }
        public void CambiarColor2(byte b)
        {
            btn5N.BackColor = Color.SlateGray;
            btn10N.BackColor = Color.SlateGray;
            btn15N.BackColor = Color.SlateGray;
            btn20N.BackColor = Color.SlateGray;
            switch (b)
            {
                case 5:
                    btn5N.BackColor = Color.Coral;
                    break;
                case 10:
                    btn10N.BackColor = Color.Coral;
                    break;
                case 15:
                    btn15N.BackColor = Color.Coral;
                    break;
                case 20:
                    btn20N.BackColor = Color.Coral;
                    break;
                case 1:
                    btn5N.BackColor = Color.SlateGray;
                    btn10N.BackColor = Color.SlateGray;
                    btn15N.BackColor = Color.SlateGray;
                    btn20N.BackColor = Color.SlateGray;
                    break;
            }
        }

        //Validar solo numeros
        private void txtTiempoPR_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            calcular.Validar(e);
            if(btnHoras.BackColor == Color.Coral)
            {
                calcular.Tiempo((Convert.ToInt32(e.KeyChar) * 60).ToString());
                CambiarColor(2);
            }
            else
            {
                calcular.Tiempo(e.KeyChar.ToString());
                CambiarColor(1);
            }
            
            
        }
        private void txtCantidadDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            calcular.Validar(e);
            calcular.Cantidad(e.KeyChar.ToString());
            CambiarColor2(1);
        }

        //Muestra los numeros aleatorios en el texbox
        private void btnGenerarN_Click(object sender, EventArgs e)
        {
            if (ComprovarA() == true)
            {
                tmrTiempo.Start();
                string a = calcular.Generar();
                calcular.Resultado(a);
                txtNumero.Text = a;
                Inhabilitar();
            }
            else
            {
                MessageBox.Show("Ingese el tiempo y la cantidad de numeros que desea generar");
            }
        }

        //Cancela la operacion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tmrTiempo.Stop();
            contador = 30;
            Habilitar();
            txtNumero.Clear();
            txtCantidadDN.Clear();
            txtTiempoPR.Clear();
            CambiarColor(3);
            CambiarColor2(1);
            LimpiarArchivos();
        }

        //Cierra la aplicacion
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Habilita e inhabilita los botones
        public void Habilitar()
        {
            btnCancelar.Enabled = false;
            btnGenerarN.Enabled = true;
            btn5.Enabled = true;
            btn10.Enabled = true;
            btn15.Enabled = true;
            btn20.Enabled = true;
            btn25.Enabled = true;
            btn30.Enabled = true;
            btn5N.Enabled = true;
            btn10N.Enabled = true;
            btn15N.Enabled = true;
            btn20N.Enabled = true;
            btnMinutos.Enabled = true;
            btnHoras.Enabled = true;
            txtTiempoPR.Enabled = true;
            txtCantidadDN.Enabled = true;
        }
        public void Inhabilitar()
        {
            btnCancelar.Enabled = true;
            btnGenerarN.Enabled = false;
            btn5.Enabled = false;
            btn10.Enabled = false;
            btn15.Enabled = false;
            btn20.Enabled = false;
            btn25.Enabled = false;
            btn30.Enabled = false;
            btn5N.Enabled = false;
            btn10N.Enabled = false;
            btn15N.Enabled = false;
            btn20N.Enabled = false;
            btnMinutos.Enabled = false;
            btnHoras.Enabled = false;
            txtTiempoPR.Enabled = false;
            txtCantidadDN.Enabled = false;
        }

        //Mimnimiza el formulario
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Mover el formulario
        int m, mx, my;
        private void pnlBarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
        private void pnlBarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if(m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }
        private void pnlBarraSuperior_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        //Temporizador
        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            if(contador < 0)
            {
                tmrTiempo.Stop();
                contador = 30;
                txtNumero.Clear();
                StreamReader tiempo = new StreamReader("Tiempo.txt");
                contador2 = Convert.ToInt32(tiempo.ReadToEnd()) * 60;
                tiempo.Close();
                tmrTiempo2.Start();
            }
            else
            {
                lblTiempo.Text = contador.ToString();
                contador--;
            }
        }
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrTiempo.Stop();
            tmrTiempo2.Stop();
            LimpiarArchivos();
        }
        private void tmrTiempo2_Tick(object sender, EventArgs e)
        {
            if (contador2 == 0)
            {
                tmrTiempo2.Stop();
                Program.principal.Hide();
                Respuesta respuesta = new Respuesta();
                respuesta.Show();
            }
            else
            {
                contador2--;
            }
        }

        //Limpia los archivos de texto
        public void LimpiarArchivos()
        {
            StreamWriter tiempo = new StreamWriter("Tiempo.txt");
            tiempo.Write("");
            tiempo.Close();
            StreamWriter cantidad = new StreamWriter("Cantidad.txt");
            cantidad.Write("");
            cantidad.Close();
            StreamWriter resultado = new StreamWriter("Resultado.txt");
            resultado.Write("");
            resultado.Close();
        }

        //Comprueva que los archivos no esten vacios 
        public bool ComprovarA()
        {
            StreamReader tiempo = new StreamReader("Tiempo.txt");
            StreamReader cantidad = new StreamReader("Cantidad.txt");
            string a = tiempo.ReadToEnd();
            string b = cantidad.ReadToEnd();
            tiempo.Close();
            cantidad.Close();
            if (a != "" && b != "")
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
