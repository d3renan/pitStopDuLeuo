using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pitStopDuLeuo.view
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrar telacadastrar = new TelaCadastrar();
            telacadastrar.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterar alterarprod = new TelaAlterar();
            alterarprod.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeletar deletarprod = new TelaDeletar();
            deletarprod.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscar buscarTela = new TelaBuscar();
            buscarTela.Show();
        }
    }
}
