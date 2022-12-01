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

namespace Memory
{
    public partial class Respuesta : Form
    {
        public Respuesta()
        {
            InitializeComponent();
        }

        CalcularTiempo calcular = new CalcularTiempo();

        //Botones de cerrar y minimizar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.principal.Show();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Valida que sole se escriban numeros
        private void txtRespuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            calcular.Validar(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Comprobar();
            }
        }

        //Comprueba la respuesta
        private void btnComprobar_Click(object sender, EventArgs e)
        {
            Comprobar();
        }

        public void Comprobar()
        {
            StreamReader result = new StreamReader("Resultado.txt");
            string x = result.ReadToEnd();
            if (x == txtRespuesta.Text)
            {
                picBien1.Visible = true;
                picBien2.Visible = true;
                picMal1.Visible = false;
                picMal2.Visible = false;
            }
            else
            {
                picMal1.Visible = true;
                picMal2.Visible = true;
                picBien1.Visible = false;
                picBien2.Visible = false;
            }
            result.Close();
        }

    }
}
