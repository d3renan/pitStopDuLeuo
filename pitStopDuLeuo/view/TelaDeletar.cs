using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pitStopDuLeuo.controller;
using pitStopDuLeuo.model;

namespace pitStopDuLeuo.view
{
    public partial class TelaDeletar : Form
    {
        public TelaDeletar()
        {
            InitializeComponent();
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            classeMercado.Codigo = Convert.ToInt32(textBox1.Text);
            manipulaProdutos mProd = new manipulaProdutos();
            mProd.buscProd();

            textBox2.Text = classeMercado.Codigo.ToString();
            textBox3.Text = classeMercado.Produto;
            textBox4.Text = classeMercado.Marca;
            textBox5.Text = classeMercado.Validade;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            classeMercado.Codigo = Convert.ToInt32(textBox2.Text);
            manipulaProdutos mProd = new manipulaProdutos();
            mProd.deletProd();

            textBox2.Text = classeMercado.Codigo.ToString();
            textBox3.Text = classeMercado.Produto;
            textBox4.Text = classeMercado.Marca;
            textBox5.Text = classeMercado.Validade;
        }

        private void TelaDeletar_Load(object sender, EventArgs e)
        {

        }
    }
}
