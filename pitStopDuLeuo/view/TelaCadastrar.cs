using pitStopDuLeuo.controller;
using pitStopDuLeuo.model;
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
    public partial class TelaCadastrar : Form
    {
        public TelaCadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classeMercado.Produto = textBox1.Text;
            classeMercado.Marca= textBox2.Text;
            classeMercado.Validade= textBox3.Text;

            manipulaProdutos mProduto = new manipulaProdutos();
            mProduto.cadProd();
        }
        public void abrirCadastro()
        {
            this.ShowDialog();
        }
    }
}
