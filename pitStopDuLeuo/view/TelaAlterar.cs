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
    public partial class TelaAlterar : Form
    {
        public TelaAlterar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            classeMercado.Codigo = Convert.ToInt32(textBox1.Text);
            manipulaProdutos mprod = new manipulaProdutos();
            mprod.buscProd();

            textBox1.Text = classeMercado.Codigo.ToString();
            textBox2.Text = classeMercado.Produto;
            textBox3.Text = classeMercado.Marca;
            textBox4.Text = classeMercado.Validade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classeMercado.Codigo = Convert.ToInt32(textBox1.Text);
            classeMercado.Produto = textBox2.Text;
            classeMercado.Marca = textBox3.Text;
            classeMercado.Validade = textBox4.Text;

            manipulaProdutos mprod = new manipulaProdutos();
            mprod.alterProd();
        }
    }
}
