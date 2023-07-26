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
    public partial class TelaBuscar : Form
    {
        public TelaBuscar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            classeMercado.Codigo = Convert.ToInt32(textBox1.Text);

            manipulaProdutos mProduto = new manipulaProdutos();
            mProduto.buscProd();

            textBox1.Text = classeMercado.Codigo.ToString();
            textBox2.Text = classeMercado.Produto;
            textBox3.Text = classeMercado.Marca;
            textBox4.Text = classeMercado.Validade;
        }
    }
}
