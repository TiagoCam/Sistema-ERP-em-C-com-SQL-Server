using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Login telaLogin = new Login();
            telaLogin.Show();
            this.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblUsuarioLogado.Text = Login.usuario;
        }

        private void pneLogo_Paint(object sender, PaintEventArgs e)
        {
            principal1.BringToFront();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            frmAtendente1.BringToFront();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCliente.BringToFront();
        }
    }
}
