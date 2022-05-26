using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFeb
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuCadastroUsuarios_Click(object sender, EventArgs e)
        {
            CadastroUsuarios formulario = new CadastroUsuarios();
            formulario.Show();
        }

        private void btnCadastroUsuarios_Click(object sender, EventArgs e)
        {
            CadastroUsuarios formulario = new CadastroUsuarios();
            formulario.Show();
        }

        private void mnuCadastroJogos_Click(object sender, EventArgs e)
        {
            CadastroJogos formulario = new CadastroJogos();
            formulario.Show();
        }

        private void btnCompraJogos_Click(object sender, EventArgs e)
        {
            CadastroJogos formulario = new CadastroJogos();
            formulario.Show();
        }
    }
}
