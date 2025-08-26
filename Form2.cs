using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySinterpartSRL_Roldan
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            frmBienvenida frmBienvenida = new frmBienvenida();
            frmBienvenida.ShowDialog();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";

            lstModulo.SelectedIndex = -1;
        }
    }
}
