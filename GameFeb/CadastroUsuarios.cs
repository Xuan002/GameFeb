using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameFeb
{
    public partial class CadastroUsuarios : Form
    {
        static String caminhoBancoDados = AppDomain.CurrentDomain.BaseDirectory + "dados/";
        static String arquivo = caminhoBancoDados + "Usuarios.txt";
        static String separadorColuna = "|";
        public CadastroUsuarios()
        {
            InitializeComponent();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            if (String.IsNullOrWhiteSpace(nome) || nome.Length < 3 || nome.Length > 255)
            {
                txtNome.Focus();
                error.SetError(txtNome, "Foi digitado menos de 3 ou mais de 255 caracteres!");
            }
            
        }

        private void tpgDadosPessoais_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            bool verificaDir = Directory.Exists(caminhoBancoDados);
            if (verificaDir == false)
            {
                Directory.CreateDirectory(caminhoBancoDados);
            }
            bool verificaArq = File.Exists(arquivo);
            if (verificaArq == false)
            {
                File.CreateText(arquivo);
            }
        }
    }
}
